﻿using InheritanceDemo;

var ogrenci = new Ogrenci()
{
    AdiSoyadi = "Seda Nur ALTUN",
    Yas = 23,
    OkulNo = "3",
    TcNo = "11111111111"
};

var ogretmen = new Ogretmen()
{
    AdiSoyadi = "Ali VELİ",
    Yas = 20,
    TcNo = "11111111111",
    Maas = 65_000
};
 
ogrenci.BilgiYazdir();
ogretmen.BilgiYazdir();
