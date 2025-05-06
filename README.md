# 🧾 Generic CRUD Operations in C#

## 📌 Loyihaning maqsadi
Bu loyiha `IGeneric<T>` interfeysi asosida C# tilida CRUD (Create, Read, Update, Delete) amallarini amalga oshiradi. Maqsad — kodni qayta ishlatish imkonini beruvchi umumiy interfeys va repository tuzilmasini yaratish.

## 🛠 Texnologiyalar
- 💻 C# 10+ (yoki siz ishlatayotgan versiya)
- 🧱 .NET (Console App / ASP.NET Core — aniqlashtirishingiz mumkin)
- 🧩 OOP — Ob'ektga yo'naltirilgan dasturlash
- 📦 Generic interfeyslar va repository pattern

## 📁 Loyihaning tuzilmasi
CRUD/
├── Models/
│   └── Students.cs               📄 Talabalar modeli
├── Services/
│   ├── Interface/
│   │   └── IGenericRegister.cs   📄 Generic interfeys
│   └── RegisterService.cs        📄 CRUD amallarni bajaruvchi service
├── Program.cs                    📄 Dastur kirish nuqtasi (Main method)
├── CRUD.csproj                   📄 Loyihani tavsiflovchi fayl

