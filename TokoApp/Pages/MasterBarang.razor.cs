using Microsoft.AspNetCore.Components;
using Radzen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TokoApp.DataAccessLibrary.Contracts;
using TokoApp.Shared.Models;

namespace TokoApp.Pages
{
    public partial class MasterBarang
    {
        [Inject] AppState AppState { get; set; }
        [Inject] IMasterBarangData MasterBarangData {get;set;}
        [Inject] NotificationService NotificationService { get; set; }


        MasterBarangViewModel data = new MasterBarangViewModel();
        List<SatuanModel> satuans = new List<SatuanModel>();
        List<MasterBarangViewModel> barangs = new List<MasterBarangViewModel>();

        protected override async Task OnInitializedAsync()
        {
            AppState.SetComponentTitle("Master Barang", "");

            SatuanModel a = new SatuanModel { KdSatuan = 1, NamaSatuan = "Buah" };
            SatuanModel b = new SatuanModel { KdSatuan = 2, NamaSatuan = "Ikat" };
            SatuanModel c = new SatuanModel { KdSatuan = 3, NamaSatuan = "Bungkus" };

            satuans.Add(a);
            satuans.Add(b);
            satuans.Add(c);

            barangs = await MasterBarangData.GetAsync();

        }

        async void SaveAsync()
        {
            try
            {
                await MasterBarangData.InsertAsync(data);
                await ReloadAsync();
                //this.StateHasChanged();
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
            catch(Exception e)
            {
                await ShowNotification(
                        new NotificationMessage()
                        {
                            Severity = NotificationSeverity.Success,
                            Summary = "Gagal disimpan",
                            Detail = e.Message,
                            Duration = 4000
                        }
                    );
            }
            
        }

        async Task ShowNotification(NotificationMessage message)
        {
            NotificationService.Notify(message);

            await InvokeAsync(() => { StateHasChanged(); });
        }

        void Cancel()
        {
            data.NamaBarang = "";
            data.KdSatuan = null;
            data.Status = false;
        }

        async void DeleteAsync(int kdBarang)
        {
            try
            {
                await MasterBarangData.DeleteAsync(kdBarang);
                await ReloadAsync();
                await ShowNotification(
                        new NotificationMessage()
                        {
                            Severity = NotificationSeverity.Success,
                            Summary = "Berhasil dihapus",
                            Detail = "",
                            Duration = 4000
                        }
                    );
            }
            catch (Exception e)
            {
                await ShowNotification(
                        new NotificationMessage()
                        {
                            Severity = NotificationSeverity.Success,
                            Summary = "Gagal dihapus",
                            Detail = e.Message,
                            Duration = 4000
                        }
                    );
            }
        }

        async Task ReloadAsync()
        {
            barangs= await MasterBarangData.GetAsync();
        }

    }
}
