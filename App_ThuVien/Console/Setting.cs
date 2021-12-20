using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using App_ThuVien.Class;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraTab;
using ThuVien.Class;

namespace App_ThuVien.Console
{
    public partial class Setting : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public Setting()
        {
            InitializeComponent();
        }

        private void toggleSwitch1_Toggled(object sender, EventArgs e)
        {

        }

        private void Setting_Load(object sender, EventArgs e)
        {
            setting_menu();
        }
        void setting_menu()
        {
            Setting_sys.getting_load();
            tS_menuLeft.IsOn = (Setting_sys.left_bar == 1) ? true : false;
            tS_menuTop.IsOn = (Setting_sys.header_ribbon == 1)?true:false;
            tab_setting.TabPages.Remove(xtab_Close);
            tab_setting.TabPages.Remove(xtab_menu);
            List<int> list = new List<int>();
            list = G_U.Loading_hide_close();
            int close = list[0];
            check_close.Checked = (close == 1) ? true : false;
        }
        Getting_UI G_U = new Getting_UI();
        public static bool left,menu,setting;
        private void tab_setting_Click(object sender, EventArgs e) // hệ code ngắn =))
        {
            ToggleSwitch ts = sender as ToggleSwitch;
            if (ts.Name == tS_menuLeft.Name)
            {
                tS_menuLeft.IsOn = (tS_menuLeft.IsOn == true) ? false : true;
                left = tS_menuLeft.IsOn;
                string status = (left == true) ? "1" : "0";
                G_U.ex_cmd_sqlite(string.Format("update laucher set left_bar = {0} ", status));
            }
            else
            {
                tS_menuTop.IsOn = (tS_menuTop.IsOn == true) ? false : true;
                menu = tS_menuTop.IsOn;
                string status = (menu == true) ? "1" : "0";
                G_U.ex_cmd_sqlite(string.Format("update laucher set header_ribbon = {0} ", status));
            }
            setting = true;
        }
        void open_tab(XtraTabPage xtab) // bao ngắn =))
        {
            if (!tab_setting.TabPages.Contains(xtab))
            {
                tab_setting.TabPages.Add(xtab);
            }
            tab_setting.SelectedTabPage = xtab;
        }

        private void btn_save_close_Click(object sender, EventArgs e)
        {
            if (check_close.Checked == true)
            {
                G_U.Changer_hide_close("close");
            }

        }

        private void aCMenu_Click(object sender, EventArgs e)
        {
            AccordionControlElement ac = sender as AccordionControlElement;
            if(ac.Name == aCMenu.Name)
            {
                open_tab(xtab_menu);
            }
            else if(ac.Name == aCThoat.Name)
            {
                open_tab(xtab_Close);
            }
        }

        private void tS_menuTop_Toggled(object sender, EventArgs e)
        {

        }
    }
}