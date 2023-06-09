﻿using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace UrunYonetim6584.Entities
{
    public class Slide : IEntity
    {
        public int Id { get; set; }
        [DisplayName("Eklenme Tarihi"), ScaffoldColumn(false)]
        public DateTime CreateDate { get; set; } = DateTime.Now;
        [DisplayName("Başlık"), StringLength(100)]
        public string Title { get; set; }
        [DisplayName("Açıklama"), StringLength(500), DataType(DataType.MultilineText)]
        public string Description { get; set; }
        [DisplayName("Resim"), StringLength(100)]
        public string Image { get; set; }
    }
}
