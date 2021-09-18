/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

package quanlynhanvien;
import java.util.ArrayList;
import java.util.Scanner;

/**
 *
 * @author ADMIN
 */
public class DSNHANVIEN {
    ArrayList <NHANVIEN> list;
    private Scanner sc;
    public DSNHANVIEN () {
        list = new ArrayList<>();
        sc = new Scanner(System.in);
    }
    public void xuatNV (){
        System.out.println("danh sach nhan vien ");
        for (NHANVIEN nv : list){
            nv.xuat();
        }
    }
    public void themMoi(){
        System.out.println("chon vai tro:");
        char ch;
        ch = 'Y';
        while (ch == 'y'|| ch == 'Y'){
            char k;
            System.out.println("nhap (s) cho cau thu, nhap (n) cho huan luyen vien");
            k = sc.next().charAt(0);
            if (k=='s'){
                NHANVIEN s = new CAUTHU ();
                s.nhap();
                list.add(s);
            } else {
                NHANVIEN n = new HUANLUYENVIEN ();
                n.nhap();
                list.add(n);
            }
            System.out.println("nhan Y de tiep tuc, nhap N de ket thuc");
            ch = sc.next().charAt(0);
        }
    }
    public void themMoi (NHANVIEN K){
        list.add(K);
    }
    public void timNV (){
        System.out.println("nhap ten nhan vien can tim: ");
        String tenNhanVien = sc.nextLine();
        for (NHANVIEN nv : list){
            if (nv.getTenNhanVien().equals(tenNhanVien)){
                nv.xuat();
                break;
            } else 
                System.out.println("khong tim thay");
        }
    }
    public void xoa (){
        System.out.println("nhap ten nhan vien can xoa: ");
        String tenNhanVien = sc.nextLine();
        NHANVIEN nvxoa = null;
        for (NHANVIEN nv : list){
            if (nv.getTenNhanVien().equalsIgnoreCase(tenNhanVien)){
                nvxoa = nv;
                break; 
            }
        }
        list.remove(nvxoa);
        System.out.println("danh sach nhan vien sau khi xoa");
        xuatNV();
    }
    public void capNhat (){
        System.out.println("nhap ten nhan vien can cap nhat");
        String tenNhanVien = sc.nextLine();
        for (int i = 0; i < list.size(); i++){
            if (list.get(i).getTenNhanVien().equalsIgnoreCase(tenNhanVien)){
                NHANVIEN nv;
                if (list.get(i) instanceof CAUTHU){
                     nv = new CAUTHU();
                } else {
                    nv = new HUANLUYENVIEN ();
                }
                nv.nhap();
                list.set(i, nv);
                   
            }
        }
    }
    public NHANVIEN timLuongMax (){
        double max = list.get (0).tinhLuong();
        int ptMax = 0;
        for (int i = 0; i<list.size(); i++){
            if (list.get(i).tinhLuong()>max){
                max = list.get(i).tinhLuong();
                ptMax = i;
            }
        }
        return list.get(ptMax);
    }
    public void taoMenu (){
        while (true){
            System.out.println("---------------------");
           System.out.println("1.Them moi nhan vien");
           System.out.println("2.Xoa nhan vien");
           System.out.println("3.Cap nhat nhan vien");
           System.out.println("4.HIen thi thong tin");
           System.out.println("5.Tim kiem nhan vien");
           System.out.println("6.Tim nhan vien co luong cao nhat");
           System.out.println("7.Ket thuc");
           int choose;
           Scanner sc = new Scanner (System.in);
           System.out.println("Lua chon cua ban ");
           choose = sc.nextInt();
           switch(choose){
               case 1 : themMoi ();break;
               case 2 : xoa();break;
               case 3 : capNhat();break;
               case 4 : xuatNV();break;
               case 5 : timNV ();break;
               case 6 : timLuongMax();break;
               case 7 : System.exit(0);
           }
        }
    }
}
