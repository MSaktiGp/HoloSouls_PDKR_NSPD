using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HoloSouls_PDKR_NSPD.Models;
using System.Configuration;
using MySql.Data.MySqlClient;


namespace HoloSouls_PDKR_NSPD.Data
{
    public static class MenuRepository
    {
        private static List<MenuModel> daftarMenu = new List<MenuModel>();

        //Contoh data awal
        
        public static void Set(List<MenuModel> menuBaru)
        {
            daftarMenu = menuBaru;
        }

        public static List<MenuModel> GetAll()
        {
            return daftarMenu;
        }

        public static void Tambah(MenuModel menu)
        {
            daftarMenu.Add(menu);
        }

        public static void Update(int index, MenuModel menu)
        {
            if (index >= 0 && index < daftarMenu.Count)
                daftarMenu[index] = menu;
        }

        public static void Hapus(int index)
        {
            if (index >= 0 && index < daftarMenu.Count)
                daftarMenu.RemoveAt(index);
        }

        public static void SimpanKeDatabase(List<MenuModel> daftarMenu)
        {
            
        }

    }
}
