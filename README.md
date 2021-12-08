# chuoiPython
def list_va_list_binh_phuong(n):
   #Khoi tao list su dung List Comprehension
   dsSoTuNhien = [i for i in range(n)]
   dsBinhPhuong = [i*i for i in range(n)]
   return dsSoTuNhien, dsBinhPhuong

#Khoi lenh co the phat sinh loi
try:
  #Nhap gia tri tu ban phim
  #Ep kieu du lieu sang so nguyen
  n = int(input())
  #Su dung cau truc re nhanh xu ly truong hop so am
  if n < 0:
      print("Vui long nhap so tu nhien!")
  else:
      #Goi thuc thi ham va truyen tham so cho ham
      dsSoTuNhien, dsBinhPhuong = list_va_list_binh_phuong(n)
      print(*dsSoTuNhien)
      print(*dsBinhPhuong)
#Khoi lenh duoc thuc thi khi loi xay ra
except:
  print("Dinh dang dau vao khong hop le!")
