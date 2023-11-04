using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace _20T1020019.Model
{
    public class SanPham
    {
        public String maSanPham {get; set;} 
        public String tenSanPham { get; set;}
        public DateTime ngaySanXuat { get; set;}
        public DateTime ngayHetHan {  get; set;}
        public long giaBan {  get; set;}
        public long soLuongNhap { get; set;}
        public String hinhDaiDien { get; set;}
        public override string ToString()
        {
            var jSon = JsonSerializer.Serialize(this);
            return jSon.ToString();
        }
        public static SanPham FromJson(string json)
        {
            return JsonSerializer.Deserialize<SanPham>(json);
        }
    }
}
