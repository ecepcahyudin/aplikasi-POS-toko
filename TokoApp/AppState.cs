using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TokoApp
{
    public class AppState
    {
        public string ComponentTitle { get; set; }
        public string PetunjukPengisianForm { get; set; }

        public event Action OnChangeComponentTitle;
        public event Action OnChangeMenu;

        public void SetComponentTitle(string title,string petunjuk="")
        {
            ComponentTitle = title;
            PetunjukPengisianForm = petunjuk;
            NotifyStateChanged();
        }

        public void SetMenu(int groupId)
        {
            //GlobalData.MenuListTemp = GlobalData.MenuList.Where(x => x.GroupId == groupId).ToList();
            //NotifyStateChanged();
        }

        //private void NotifyStateChanged() => OnChangeComponentTitle?.Invoke();

        private void NotifyStateChanged()
        {
            OnChangeComponentTitle?.Invoke();
            OnChangeMenu?.Invoke();
        }
        


    }
}
