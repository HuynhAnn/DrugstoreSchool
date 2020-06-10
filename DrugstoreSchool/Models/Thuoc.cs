using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DrugstoreSchool.Models
{
    public class Thuoc
    {
        private int id;
        private string ThanhPhan;
        private string NhomThuoc;
        private string DangThuoc;
        private string SanXuat;
        private string DangKy;
        private string Image_cover;

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        [Required (ErrorMessage =" Tiêu đề không được để trống")]
        [StringLength(250,ErrorMessage ="Tiêu đề không được vượt quá 250 ký tự")]
        [Display(Name ="Tiêu đề")]

        public string ThanhPhan1
        {
            get
            {
                return ThanhPhan;
            }

            set
            {
                ThanhPhan = value;
            }
        }

        public string NhomThuoc1
        {
            get
            {
                return NhomThuoc;
            }

            set
            {
                NhomThuoc = value;
            }
        }

        public string DangThuoc1
        {
            get
            {
                return DangThuoc;
            }

            set
            {
                DangThuoc = value;
            }
        }

        public string SanXuat1
        {
            get
            {
                return SanXuat;
            }

            set
            {
                SanXuat = value;
            }
        }

        public string DangKy1
        {
            get
            {
                return DangKy;
            }

            set
            {
                DangKy = value;
            }
        }

        public string Image_cover1
        {
            get
            {
                return Image_cover;
            }

            set
            {
                Image_cover = value;
            }
        }

        public Thuoc()
        {

        }

        public Thuoc(int id, string thanhPhan, string nhomThuoc, string dangThuoc, string sanXuat, string dangKy, string image_cover)
        {
            this.id = id;
            ThanhPhan = thanhPhan;
            NhomThuoc = nhomThuoc;
            DangThuoc = dangThuoc;
            SanXuat = sanXuat;
            DangKy = dangKy;
            Image_cover = image_cover;
        }
        
    }
}