using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using ShopDT.Models;

namespace ShopDT.Areas.Admin.Models
{
    public class SpViewModel
    {
        QLDienThoaiContext db = new QLDienThoaiContext();
        public Sanpham sp { get; set; }
        public SelectList Danhmuc { get; set; }
        public SpViewModel()
        {
            this.Danhmuc = new SelectList(db.Danhmucsps, "MaDanhMuc", "TenDanhMuc");
        }
    }
}
