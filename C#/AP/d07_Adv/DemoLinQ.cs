﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading.Tasks;

namespace d07_Adv
{
    class DemoLinQ
    {
        List<Student> ds = new List<Student>
        {
            new Student{id = "S1",name = "Dung Ngo Thi Doan",mark = 82},
            new Student{id = "S11",name = "Tam Hoang Minh",mark = 84},
            new Student{id = "S32",name = "Hoa Nguyen Van Tran",mark = 97},
            new Student{id = "S12",name = "Hoa Nguyen Van Tran",mark = 79},
            new Student{id = "S14",name = "Huy Nguyen Dinh",mark = 93},
            new Student{id = "S03",name = "Trung Vo Hoang",mark = 78},
            new Student{id = "S21",name = "Buu Loi Buu",mark = 75},
            new Student{id = "S14",name = "Huyen Nguyen Thi Phuong",mark = 74},
            new Student{id = "S08",name = "Thu Vo Minh",mark = 79}
        };

        public void Test()
        {
            Console.Clear();
            Console.WriteLine("Demo Linq - Collection");

            Console.WriteLine("\n Danh sach sinh vien");
            ds.ForEach(item => Console.WriteLine(item));

            Console.WriteLine("\n Danh sach sinh vien - theo thu tu theo ten");
            var dsID = from item in ds orderby item.name, item.id select item;
            dsID.ToList().ForEach(item => Console.WriteLine(item));
            //foreach (var sv in ds.OrderBy(item => (item.name, item.id)))
            //{
            //    Console.WriteLine(sv);
            //}

            Console.WriteLine("Danh sach sinh vien co ten [Hoa]");
            var dsten = from item in ds
                        where item.name.Contains("Hoa")
                        orderby item.mark descending
                        select item;
            if (dsten.Count() == 0)
            {
                Console.WriteLine("Khong tim thay !!!");
            }
            else
            {
                Console.WriteLine("\n Danh sach sinh vien co ten [Hoa]");
                foreach (var sv in dsten)
                {
                    Console.WriteLine(sv);
                }
            }


            Console.ReadKey(true);
        }
    }
}
