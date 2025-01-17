﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mimari
{
   
    class Kamp_Otobus : ISoyutFabrika
    {
        string k_sehir, k_ad;
        int k_gun, k_kisi, s_tip, k_fiyat, oto_fiyat;

        string oto_firma, oto_kalkis, oto_varis;
        DateTime oto_gidis, oto_donus;
        public Kamp_Otobus(string sehir, string ad, int gun, int kisi, int tip, string firma, string kalkis, string varis, DateTime gidis, DateTime donus, int k_fiyat, int u_fiyat)
        {
            k_sehir = sehir;
            k_ad = ad;
            k_gun = gun;
            k_kisi = kisi;
            s_tip = tip;
            this.k_fiyat = k_fiyat;

            oto_firma = firma;
            oto_kalkis = kalkis;
            oto_varis = varis;
            oto_gidis = gidis;
            oto_donus = donus;
            this.oto_fiyat = u_fiyat;
        }
        public IKonaklama KonaklamaOlustur()
        {
            return new Kamp(k_sehir, k_ad, k_gun, k_kisi, k_fiyat);
        }
        public IUlasim UlasimOlustur()
        {
            return new Otobus(oto_firma, oto_kalkis, oto_varis, oto_gidis, oto_donus, s_tip, k_kisi, oto_fiyat);
        }
    }
}
