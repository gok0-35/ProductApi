# ProductAPI

ASP.NET Core Web API kullanılarak geliştirilmiş, **JWT tabanlı kimlik doğrulama**, **ASP.NET Core Identity** ve **Entity Framework Core (SQLite)** içeren örnek bir ürün yönetim API’sidir.

---

## 🚀 Kullanılan Teknolojiler

* ASP.NET Core Web API
* Entity Framework Core
* SQLite
* ASP.NET Core Identity
* JWT Bearer Authentication
* Swagger / OpenAPI

---

## 📂 Proje Yapısı

```
ProductAPI/
├── Controllers/
│   ├── ProductsController.cs
│   └── UsersController.cs
│
├── DTO/
│   ├── ProductDTO.cs
│   ├── UserDTO.cs
│   └── LoginDTO.cs
│
├── Models/
│   ├── Product.cs
│   ├── AppUser.cs
│   ├── AppRole.cs
│   └── ProductsContext.cs
│
├── Migrations/
├── Program.cs
├── appsettings.json
└── README.md
```

---

## 🔐 Authentication (JWT)

* Login işlemi sonrası JWT token üretilir
* `[Authorize]` attribute ile endpoint koruması sağlanır
* Token süresi: **1 gün**

---

## 🧑‍💻 Users API

### Register

```
POST /api/users/register
```

### Login

```
POST /api/users/login
```

Response:

```json
{ "token": "jwt-token" }
```

---

## 📦 Products API

* `GET /api/products` → Aktif ürünleri listeler
* `GET /api/products/{id}` → (Authorize) Tek ürün getirir
* `POST /api/products` → Ürün ekler
* `PUT /api/products/{id}` → Ürün günceller
* `DELETE /api/products/{id}` → Ürün siler

---

## ⚙️ Konfigürasyon

```json
{
  "AppSettings": {
    "Secret": "JWT_SECRET_KEY"
  }
}
```

> Gerçek projelerde bu değer environment variable veya secret manager üzerinden yönetilmelidir.

---

## 🧪 Swagger

Development ortamında otomatik olarak aktiftir:

```
/swagger
```

JWT destekli test imkanı sunar.

---

## ▶️ Çalıştırma

```bash
dotnet restore
dotnet ef database update
dotnet run
```

---

## 📌 Not

Bu proje eğitim ve demo amaçlı hazırlanmıştır.
