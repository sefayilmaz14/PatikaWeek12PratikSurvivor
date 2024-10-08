# PatikaWeek12PratikSurvivor

Bu proje, Patika.dev platformundaki 12. hafta ödevi olan Code First yaklaşımıyla geliştirilen bir yarışma simülasyonu uygulamasıdır. Projede Entity Framework kullanılarak veritabanı ilişkileri modellenmiş ve bir yarışmacı yönetim sistemi geliştirilmiştir.

## 📋 İçindekiler

- [Kurulum](#kurulum)
- [Kullanım](#kullanım)
- [Proje Yapısı](#proje-yapısı)
- [Kullanılan Teknolojiler](#kullanılan-teknolojiler)

## 🚀 Kurulum

Projeyi yerel bilgisayarınıza kurmak için şu adımları izleyin:

1. Bu repoyu klonlayın:
    git clone https://github.com/sefayilmaz14/PatikaWeek12PratikSurvivor.git
   
2. Projeyi Visual Studio ile açın:
PatikaWeek12PratikSurvivor.sln dosyasını açın.

3. Gerekli NuGet paketlerini yükleyin:
Visual Studio'da Çözüm Gezgini'nde sağ tıklayıp NuGet Paketlerini Geri Yükle seçeneğine tıklayın.

4. Veritabanını güncelleyin:
Package Manager Console'da şu komutu çalıştırın: update-database

## 💻 Kullanım
Projeyi çalıştırdıktan sonra Swagger UI veya Postman kullanarak API'ye erişebilirsiniz.

## 🗂️ Proje Yapısı
Entities: Veritabanındaki tabloları temsil eden sınıflar.
Controllers: API isteklerini yöneten sınıflar.
Migrations: Entity Framework migration dosyalarının bulunduğu klasör.

## 🛠️ Kullanılan Teknolojiler
.NET Core
Entity Framework Core
SQL Server
Swagger (API dokümantasyonu)
