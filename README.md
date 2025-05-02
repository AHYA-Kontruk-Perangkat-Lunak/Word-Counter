# Word-Counter
📖 Tutorial Membuat Branch Baru dan Push ke Branch Sendiri di GitHub

Membuat Branch Baru:
Langkah 1: Clone Repo dari GitHub

https://github.com/AHYA-Kontruk-Perangkat-Lunak/Word-Counter.git

cd Word-Counter

Langkah 2: Pastikan di Branch Utama (main)

Sebelum buat branch baru, pastikan kamu sudah update dari branch utama:

git checkout main

git pull origin main

Langkah 3: Membuat Branch Baru

Sekarang buat branch baru berdasarkan fitur yang kamu kerjakan.

Misalnya, kamu mau buat fitur untuk hitung jumlah kata:

git checkout -b fitur-hitung-kata

-b artinya membuat branch baru dan langsung pindah ke branch tersebut.

Penamaan branch sebaiknya pakai format:

fitur-nama-fitur atau feature/nama-fitur

Push ke Branch Sendiri:
1. git add .

2. git commit -m "Menambahkan fitur hitung jumlah kata"

3. git push -u origin (branch kamu)

Keterangan:

-u memberitahu Git untuk mengingat branch ini.

origin adalah nama remote default (GitHub repo).

fitur-hitung-kata adalah nama branch kamu.
