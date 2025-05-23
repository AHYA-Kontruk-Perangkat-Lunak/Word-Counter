---
marp: true
header: 
footer: ![height:40px](https://www.markslides.ai/image/credit.png)
paginate: false
class: normal
theme: default
size: 16:9
style: |
  pre {
    overflow: auto;
  }
---



### **Slide 1: Judul**
**Design Pattern dalam Pengembangan Perangkat Lunak**  
Oleh: Fidi W Putro  
Tanggal: 20 Mei 2025

---

### **Slide 2: Apa Itu Design Pattern?**
**Definisi:**  
> *Design pattern adalah solusi baku untuk masalah desain perangkat lunak yang umum terjadi.*

**Analogi:**  
Bayangkan kamu sedang membangun rumah. Daripada merancang sendiri bagaimana cara membuat pintu atau jendela, kamu bisa menggunakan **desain standar** yang sudah terbukti baik dan efisien.

---

### **Slide 3: Kenapa Harus Gunakan Design Pattern?**
**Manfaat:**
- Meningkatkan **reusability** (boleh pakai ulang)
- Membuat kode lebih **terstruktur dan mudah dimaintain**
- Membantu komunikasi antar developer
- Mencegah kesalahan desain berulang

**Contoh Kasus:**  
Kamu ingin membuat sistem notifikasi yang bisa dikembangkan untuk menambahkan metode baru (email, SMS, Push Notification) tanpa mengubah kode lama → gunakan **Strategy Pattern**.

---

### **Slide 4: Klasifikasi Design Pattern**
Dibagi menjadi 3 kategori:

| Jenis | Fungsi | Contoh |
|-------|--------|--------|
| **Creational** | Membuat objek | Factory Method, Singleton |
| **Structural** | Menyusun struktur objek | Adapter, Decorator |
| **Behavioral** | Komunikasi antar objek | Observer, Strategy |

---

### **Slide 5: Creational Patterns – Apa Saja?**
Fokus pada **cara pembuatan objek** agar fleksibel dan mudah dikembangkan.

Contoh:
- **Factory Method**: Membuat objek berdasarkan kebutuhan.
- **Abstract Factory**: Membuat keluarga objek terkait.
- **Singleton**: Hanya ada satu instance dari sebuah class.
- **Prototype**: Duplikasi objek yang sudah ada.

---

### **Slide 6: Contoh Kasus – Factory Method**
**Masalah:**  
Aplikasi harus membuat objek berbeda tergantung platform (Windows, Mac).

**Solusi:**  
Gunakan **Factory Method** untuk membuat objek UI sesuai OS.

**Analogi:**  
Seperti restoran yang menyediakan menu berbeda untuk sarapan dan makan malam → pilihan makanan dibuat sesuai waktu.

---

### **Slide 7: Structural Patterns – Apa Saja?**
Mengatur hubungan antar objek/class agar struktur lebih fleksibel dan stabil.

Contoh:
- **Adapter**: Menyesuaikan interface yang tidak cocok.
- **Decorator**: Menambah fitur secara dinamis.
- **Facade**: Menyederhanakan akses ke sistem kompleks.
- **Proxy**: Mengontrol akses ke objek.

---

### **Slide 8: Contoh Kasus – Adapter**
**Masalah:**  
Sistem lama bekerja dengan format XML, tapi sistem baru butuh JSON.

**Solusi:**  
Gunakan **Adapter Pattern** untuk mengubah output XML ke JSON.

**Analogi:**  
Seperti adaptor listrik saat bepergian ke negara lain → tetap bisa pakai gadget meskipun stop kontak beda bentuk.

---

### **Slide 9: Behavioral Patterns – Apa Saja?**
Menentukan **komunikasi antar objek** agar lebih terorganisir.

Contoh:
- **Observer**: Notifikasi otomatis jika ada perubahan data.
- **Strategy**: Bisa ganti algoritma di tengah jalan.
- **Command**: Menyimpan perintah sebagai objek.
- **Chain of Responsibility**: Alur request diteruskan hingga ditemukan handler.

---

### **Slide 10: Contoh Kasus – Observer**
**Masalah:**  
Ada aplikasi cuaca yang harus memberitahu semua layar jika ada perubahan suhu.

**Solusi:**  
Gunakan **Observer Pattern** → semua layar akan mendapat notifikasi otomatis saat data berubah.

**Analogi:**  
Seperti langganan koran → setiap hari koran datang ke rumah tanpa harus memesan ulang.

---

### **Slide 11: Tantangan Tanpa Design Pattern**
- Kode susah dipelihara
- Sulit ditambah fitur baru
- Rentan error saat ada perubahan
- Duplicated code everywhere

**Ilustrasi:**  
Bangunan tanpa blueprint → sulit direnovasi, rawan runtuh.

---

### **Slide 12: Keuntungan dengan Design Pattern**
- Fleksibilitas tinggi
- Mudah dikembangkan
- Lebih sedikit bug
- Reusable components

**Ilustrasi:**  
Bangunan dengan blueprint → mudah direnovasi, aman, dan bisa disesuaikan.

---

### **Slide 13: Contoh Studi Kasus Nyata**
**Studi Kasus: Aplikasi Editor Dokumen**

Masalah:
- Format dokumen berbeda (PDF, DOCX, HTML)
- Antarmuka user berbeda (Light Mode, Dark Mode)

Solusi:
- Gunakan **Abstract Factory** untuk membuat UI komponen sesuai tema.
- Gunakan **Strategy** untuk ekspor file ke berbagai format.

---

### **Slide 14: Framework vs Design Pattern**
|                | Design Pattern       | Framework               |
|----------------|----------------------|--------------------------|
| Abstraksi      | Tinggi               | Rendah (sudah diimplementasi) |
| Penggunaan     | Panduan desain       | Siap pakai               |
| Contoh         | Observer, Factory    | Spring, React            |

**Analogi:**  
Pattern = resep masakan  
Framework = makanan siap saji

---

### **Slide 15: Anti-Patterns (Yang Harus Dihindari)**
Beberapa pola yang tampak seperti design pattern tapi justru bikin masalah:

- **Golden Hammer**: Paksa pakai satu pattern untuk semua masalah.
- **God Object**: Satu class melakukan segalanya.
- **Spaghetti Code**: Struktur acak-acakan.

---

### **Slide 16: Kapan Harus Gunakan Design Pattern?**
Pertimbangkan ketika:
- Ada perubahan sering terjadi
- Sistem besar dan kompleks
- Butuh fleksibilitas tinggi
- Ingin meningkatkan maintainability

**Tips:**  
JANGAN over-engineering! Gunakan hanya jika benar-benar dibutuhkan.

---

### **Slide 17: Tools & Teknologi Pendukung**
- UML Diagram (Visual Paradigm, Draw.io)
- IDE dengan refactoring tools (VSCode, IntelliJ IDEA)
- Framework yang support design patterns (Spring, Laravel, React)

---

### **Slide 18: Prinsip SOLID & Design Pattern**
Design pattern sering selaras dengan prinsip **SOLID**:
- **Single Responsibility**
- **Open/Closed**
- **Liskov Substitution**
- **Interface Segregation**
- **Dependency Inversion**


### **Slide 21: Factory Method – Struktur & Kode C#**

#### **Struktur UML**
```
[Creator]        [Product]
   ↑                ↑
[ConcreteCreator] [ConcreteProduct]
```

#### **Kasus Nyata:**  
Aplikasi pembuatan laporan keuangan yang bisa di-export ke PDF, Excel, atau Word.

#### **Contoh Kode C#:**
```csharp
// Interface Produk
public interface IReport
{
    void Generate();
}

// Produk Spesifik
public class PdfReport : IReport
{
    public void Generate() => Console.WriteLine("Generate PDF Report");
}

public class ExcelReport : IReport
{
    public void Generate() => Console.WriteLine("Generate Excel Report");
}

// Creator Abstrak
public abstract class ReportFactory
{
    public abstract IReport CreateReport();
}

// Concrete Creator
public class PdfReportFactory : ReportFactory
{
    public override IReport CreateReport() => new PdfReport();
}

public class ExcelReportFactory : ReportFactory
{
    public override IReport CreateReport() => new ExcelReport();
}

// Penggunaan
class Program
{
    static void Main()
    {
        ReportFactory factory = new PdfReportFactory();
        IReport report = factory.CreateReport();
        report.Generate(); // Output: Generate PDF Report
    }
}
```

---

### **Slide 22: Singleton – Struktur & Kode C#**

#### **Struktur UML**
```
[Singleton]
   - instance
   + GetInstance()
   + DoSomething()
```

#### **Kasus Nyata:**  
Logger sistem atau database connection pool → hanya boleh ada satu instance sepanjang aplikasi berjalan.

#### **Contoh Kode C#:**
```csharp
public sealed class Logger
{
    private static readonly Logger _instance = new Logger();

    private Logger() { }

    public static Logger GetInstance() => _instance;

    public void Log(string message) => Console.WriteLine($"Log: {message}");
}

// Penggunaan
class Program
{
    static void Main()
    {
        Logger logger = Logger.GetInstance();
        logger.Log("App started"); // Output: Log: App started
    }
}
```

---

### **Slide 23: Observer – Struktur & Kode C#**

#### **Struktur UML**
```
[Subject]      [Observer]
   ↑               ↑
[ConcreteSubject][ConcreteObserver]
```

#### **Kasus Nyata:**  
Sistem notifikasi harga saham → ketika harga berubah, semua pelanggan mendapat notifikasi otomatis.

#### **Contoh Kode C#:**
```csharp
using System;
using System.Collections.Generic;

// Subjek
public class StockMarket
{
    private List<IInvestor> investors = new List<IInvestor>();
    private string stockName;
    private decimal price;

    public string StockName => stockName;
    public decimal Price => price;

    public void SetPrice(decimal newPrice)
    {
        price = newPrice;
        Notify();
    }

    public void Attach(IInvestor investor) => investors.Add(investor);
    public void Detach(IInvestor investor) => investors.Remove(investor);

    private void Notify()
    {
        foreach (var investor in investors)
        {
            investor.Update(this);
        }
    }
}

// Observer
public interface IInvestor
{
    void Update(StockMarket stock);
}

public class Investor : IInvestor
{
    public void Update(StockMarket stock)
    {
        Console.WriteLine($"Notifikasi untuk investor: Harga {stock.StockName} menjadi {stock.Price}");
    }
}

// Penggunaan
class Program
{
    static void Main()
    {
        var market = new StockMarket();
        market.StockName = "AAPL";
        
        var investor1 = new Investor();
        var investor2 = new Investor();

        market.Attach(investor1);
        market.Attach(investor2);

        market.SetPrice(150.25m); // Notifikasi dikirim ke investor1 dan investor2
    }
}
```

---

### **Slide 24: Strategy – Struktur & Kode C#**

#### **Struktur UML**
```
[Context]
   ↓
[Strategy]
   ↑
[ConcreteStrategyA] [ConcreteStrategyB]
```

#### **Kasus Nyata:**  
Metode pembayaran dalam aplikasi e-commerce → bisa ganti strategi antara kartu kredit, transfer bank, atau COD.

#### **Contoh Kode C#:**
```csharp
// Strategi
public interface IPaymentStrategy
{
    void Pay(int amount);
}

// Strategi Konkret
public class CreditCardPayment : IPaymentStrategy
{
    public void Pay(int amount) => Console.WriteLine($"Paid {amount} via Credit Card");
}

public class BankTransferPayment : IPaymentStrategy
{
    public void Pay(int amount) => Console.WriteLine($"Paid {amount} via Bank Transfer");
}

// Konteks
public class ShoppingCart
{
    private IPaymentStrategy _strategy;

    public void SetPaymentStrategy(IPaymentStrategy strategy)
    {
        _strategy = strategy;
    }

    public void Checkout(int totalAmount)
    {
        _strategy.Pay(totalAmount);
    }
}

// Penggunaan
class Program
{
    static void Main()
    {
        var cart = new ShoppingCart();
        cart.SetPaymentStrategy(new CreditCardPayment());
        cart.Checkout(500); // Output: Paid 500 via Credit Card

        cart.SetPaymentStrategy(new BankTransferPayment());
        cart.Checkout(300); // Output: Paid 300 via Bank Transfer
    }
}
```

---

### **Slide 25: Decorator – Struktur & Kode C#**

#### **Struktur UML**
```
[Component]
   ↑
[ConcreteComponent]
   ↑
[Decorator]
   ↑
[ConcreteDecoratorA] [ConcreteDecoratorB]
```

#### **Kasus Nyata:**  
Penambahan fitur dinamis pada objek sandwich seperti tambahan keju, sayuran, daging.

#### **Contoh Kode C#:**
```csharp
// Komponen Dasar
public interface ISandwich
{
    string Description();
    double Cost();
}

// Komponen Konkret
public class BasicSandwich : ISandwich
{
    public string Description() => "Basic Sandwich";
    public double Cost() => 2.0;
}

// Dekorator Dasar
public abstract class SandwichDecorator : ISandwich
{
    protected ISandwich decoratedSandwich;
    public SandwichDecorator(ISandwich sandwich) => decoratedSandwich = sandwich;

    public virtual string Description() => decoratedSandwich.Description();
    public virtual double Cost() => decoratedSandwich.Cost();
}

// Dekorator Konkret
public class CheeseDecorator : SandwichDecorator
{
    public CheeseDecorator(ISandwich sandwich) : base(sandwich) {}

    public override string Description() => decoratedSandwich.Description() + ", Cheese";
    public override double Cost() => decoratedSandwich.Cost() + 0.5;
}

public class LettuceDecorator : SandwichDecorator
{
    public LettuceDecorator(ISandwich sandwich) : base(sandwich) {}

    public override string Description() => decoratedSandwich.Description() + ", Lettuce";
    public override double Cost() => decoratedSandwich.Cost() + 0.3;
}

// Penggunaan
class Program
{
    static void Main()
    {
        ISandwich sandwich = new BasicSandwich();
        sandwich = new CheeseDecorator(sandwich);
        sandwich = new LettuceDecorator(sandwich);

        Console.WriteLine($"{sandwich.Description()} - ${sandwich.Cost():F2}");
        // Output: Basic Sandwich, Cheese, Lettuce - $2.80
    }
}
```

---

### **Slide 26: Adapter – Struktur & Kode C#**

#### **Kasus Nyata:**  
Integrasi sistem lama yang menggunakan XML ke API baru yang butuh JSON.

#### **Contoh Kode C#:**
```csharp
// Target
public interface IJsonService
{
    void SendData(string jsonData);
}

// Legacy Service
public class XmlService
{
    public void SendXmlData(string xmlData) => Console.WriteLine($"Sending XML Data: {xmlData}");
}

// Adapter
public class XmlToJsonAdapter : IJsonService
{
    private XmlService _xmlService;

    public XmlToJsonAdapter(XmlService service) => _xmlService = service;

    public void SendData(string jsonData)
    {
        string xmlData = ConvertJsonToXml(jsonData);
        _xmlService.SendXmlData(xmlData);
    }

    private string ConvertJsonToXml(string json) => "<data>" + json + "</data>";
}

// Penggunaan
class Program
{
    static void Main()
    {
        var legacyService = new XmlService();
        var adapter = new XmlToJsonAdapter(legacyService);

        adapter.SendData("{name: 'John', age: 30}");
        // Output: Sending XML Data: <data>{name: 'John', age: 30}</data>
    }
}
```
