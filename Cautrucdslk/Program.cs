using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cautrucdslk
{
    class Node
    {
        private int info;
        private Node next;

        public Node(int x)
        {
            info = x;
            next = null;
        }
        public int Info
        {
            set { info = value; }
            get { return info; }

        }
        public Node Next
        {
            set { next = value; }
            get { return next; }
        }
    }
    class SingleLinkList
    {
        private Node Head;
        public SingleLinkList()
        {
            Head = null;
        }
        public void AddHead(int x)
        {
            Node p = new Node(x);
            p.Next = Head;
            Head = p;
        }
        public void AddLast(int x)
        {
            Node p = new Node(x);
            if (Head == null)
            {
                Head = p;
            }
            else
            {
                Node q = Head;
                while (q.Next != null)
                {
                    q = q.Next;
                }
            }
        }
        public void DeleteLast()
        {
            if (Head != null)
            {
                Node p = Head;
                Node q = null;
                while (p.Next != null)
                {
                    q = p;
                    p = p.Next;
                }
                q.Next = null;
            }
        }
        public void DeleteHead()
        {
            if (Head != null)
            {
                Node p = Head;
                Head = Head.Next;
                p.Next = null;
            }
        }
        public void DeleteNode(int x)
        {
            if (Head != null)
            {
                Node p = Head;
                Node q = null;
                while (p != null && p.Info != x)
                {
                    q = p;
                    p = p.Next;
                }
                if (p != null)
                {
                    if (p == Head)
                    {
                        DeleteHead();
                    }
                    else
                    {
                        q.Next = p.Next;
                        p.Next = null;
                    }
                }
            }
        }
        public Node findMax()
        {
            Node max = Head;
            Node p = Head.Next;
            while (p != null)
            {
                if (p.Info > max.Info)
                {
                    max = p;
                }
                p = p.Next;
            }
            return max;
        }
        public int Avg()
        {
            int sum = 0;
            int count = 0;
            Node p = Head;
            while (p != null)
            {
                sum += p.Info;
                count++;
                p = p.Next;

            }
            return sum / count;
        }
        public void ProcessList()
        {
            Node p = Head;
            while (p != null)
            {
                Console.Write($"{p.Info}");
                p = p.Next;
            }
        }
    }
    class Program
    {
        static void NhapDanhSach(SingleLinkList s)
        {
            string chon = "y";
            int x;
            while (chon != "n")
            {
                Console.Write("Nhap gia tri nut:");
                x = int.Parse(Console.ReadLine());
                s.AddHead(x);
                Console.Write("Tiep tuc(y/n?)");
                chon = Console.ReadLine();
            }
        }
        static void Main(string[] args)
        {
            SingleLinkList s = new SingleLinkList();

            s.AddHead(4);
            s.AddHead(8);
            s.AddLast(5);
            s.AddHead(10);
            s.AddLast(1);
            Console.Write("Danh sach lien ket:");
            s.ProcessList();

            Console.WriteLine("\n-----Danh sach nut nhap tu ban phim----");
            NhapDanhSach(s);
            Console.Write("Danh sach lien ket:");
            s.ProcessList();

            s.DeleteHead();
            Console.Write("\nDanh sach lien ket sau khi xoa dau:");
            s.ProcessList();

            s.DeleteLast();
            Console.Write("\nDanh sach lien ket sau khi xoa cuoi:");
            s.ProcessList();

            s.DeleteLast();
            Console.Write("\nDanh sach lien ket sau khi xoa cuoi:");
            s.ProcessList();

            Console.Write("\nNhap gia tri x can xoa:");
            int x = int.Parse(Console.ReadLine());
            s.DeleteNode(x);
            Console.Write($"\nDanh sach lien ket sau khi xoa nut co gia tri:");
            s.ProcessList();


            Console.Write($"\nNut co gia tri lon nhat:{s.findMax().Info}");


            Console.Write($"\nGia tri trung binh cac nut:{s.Avg()}");

            Console.ReadLine();

        }
    }
}
