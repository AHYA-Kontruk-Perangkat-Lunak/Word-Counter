
# **📖 Membuat Branch Baru dan Push ke Branch Sendiri**

## **NOTE :**
* Kalau mau coding pastikan kamu ada di branch kamu
* Jangan lupa untuk git pull origin main untuk menyamakan dengan di git main

## **Membuat Branch Baru :**

### **Langkah 1: Clone Repo dari GitHub**

* git clone https://github.com/AHYA-Kontruk-Perangkat-Lunak/Word-Counter.git

* cd `Word-Counter`

### **Langkah 2: Pastikan di Branch Utama (main)**

* git checkout main

* git pull origin main

### **Langkah 3: Membuat Branch Baru**

* git checkout -b (fitur yang kamu kerjakan)

* -b artinya membuat branch baru dan langsung pindah ke branch tersebut.

## **Push ke Branch Sendiri :**
1. git add .

2. git commit -m "Menambahkan fitur hitung jumlah kata"

3. git push -u origin (nama branch kamu)

## **Push dari Branch Sendiri ke Main :**
1. git checkout main

2. git pull origin

3. git merge (nama branch kamu)

4. git push origin main

5. git checkout (nama branch kamu)

## **Command Github :**

1. git add . (untuk menambahkan semua perubahan di direktori saat ini)

2. git commit -m "Pesan commit" (menjelaskan perubahan yang dilakukan.)

3. git push origin <branch-name> (untuk mendorong perubahan ke branch tertentu)

4. git branch (untuk melihat semua branch lokal)

5. git checkout <branch-name> (untuk berpindah ke branch lain)
