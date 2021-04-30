using ZXing;
using System.Drawing;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Threading.Tasks;
using Radzen;
using Radzen.Blazor;
using System.Linq;
using TokoApp.DataAccessLibrary.Contracts;
using TokoApp.Shared.Models;
using TokoApp.Pages.Dialogs;
using System;

namespace TokoApp.Pages
{
    public partial class Penjualan
    {

        [Inject] AppState AppState { get; set; }
        [Inject] IBarangData BarangData { get; set; }
        [Inject] IPenjualanData PenjualanData { get; set; }
        [Inject] DialogService dialogService { get; set; }
        [Inject] NotificationService NotificationService { get; set; }

        List<PenjualanViewModel> penjualans = new List<PenjualanViewModel>();
        List<BarangModel> barangs = new List<BarangModel>();
       
        protected override async Task OnInitializedAsync()
        {
            AppState.SetComponentTitle("Penjualan","");
            barangs = await BarangData.GetHargasAsync("100");
            dialogService.OnClose += DialogClosed;

        }

        public void DecodeBarcode()
        {
            // create a barcode reader instance
            BarcodeReader reader = new BarcodeReader();
            // load a bitmap
            var barcodeBitmap = (Bitmap)Image.FromFile("E:\\Ecep\\Toko\\SSCC-Pallet-Barcode.jpg");
            // detect and decode the barcode inside the bitmap
            var result = reader.Decode(barcodeBitmap);
            // do something with the result
            if (result != null)
            {
               //txtDecoderType.Text = result.BarcodeFormat.ToString();
               //kdBarang = result.Text;
                //this.StateHasChanged();
            }
        }

        void SelectedBarangChanged(PenjualanViewModel penjualan, object barang)
        {
            penjualan.Satuan = ((BarangModel)barang).Satuan;
            penjualan.NamaBarang = ((BarangModel)barang).NamaBarang;
            penjualan.Harga= ((BarangModel)barang).Harga;
            penjualan.NoPenerimaan = ((BarangModel)barang).NoPenerimaan;

        }

        void Cancel()
        {
            penjualans.Clear();
            penjualansGrid.Reload();
    
        }

        void Bayar()
        {
            if (penjualans.Sum(o => o.JmlBayar) <= 0)
                return;

            dialogService.Open<BayarDialog>
                (
                
                    "Bayar",

                    new Dictionary<string, object>()
                    {
                        { "JmlHarudDibayar",penjualans.Sum(o=>o.JmlBayar)}
                    },
                    new DialogOptions { Width="500px",Height="250px"}
                
                );

            
        }

        async void DialogClosed(dynamic result)
        {
            if (result == null)
                result = false;

            if (result)
            {
                try
                {
                    int resultInsert = await PenjualanData.Insert(penjualans);
                    Cancel();
                    await ShowNotification(
                        new NotificationMessage()
                        {
                            Severity = NotificationSeverity.Success,
                            Summary = "Berhasil disimpan",
                            Detail = "",
                            Duration = 4000
                        }
                    );
                }
                catch (Exception e)
                {
                    await ShowNotification(
                        new NotificationMessage()
                            { Severity = NotificationSeverity.Success, 
                                Summary = "Gagal disimpan", 
                                Detail = e.Message, 
                                Duration = 4000 
                            }
                    );
                }
                
            }
                
        }

        async Task ShowNotification(NotificationMessage message)
        {
            NotificationService.Notify(message);

            await InvokeAsync(() => { StateHasChanged(); });
        }



    }
}
