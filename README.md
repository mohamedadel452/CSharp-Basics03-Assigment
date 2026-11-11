<div dir="rtl">

# 💻 أساسيات C# — المحاضرة 03: معمارية النصوص (Strings & StringBuilder)، جمل التحكم، والحلقات
### C# Basics 03: String Intern Pool, StringBuilder, Control Flow & Loops (18 Exercises)

[![.NET](https://img.shields.io/badge/.NET-10.0-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)](https://dotnet.microsoft.com/)
[![C#](https://img.shields.io/badge/C%23-14.0-239120?style=for-the-badge&logo=c-sharp&logoColor=white)](https://learn.microsoft.com/en-us/dotnet/csharp/)
[![Module](https://img.shields.io/badge/Module-01_CSharp_Basics-0284c7?style=for-the-badge)](#)
[![Interactive Guide](https://img.shields.io/badge/%F0%9F%8C%90_Live_Study_Guide-HTML_Interactive-8b5cf6?style=for-the-badge)](https://htmlpreview.github.io/?https://github.com/mohamedadel452/CSharp-Basics03-Assigment/blob/master/Study_Guide/CSharp_Basics_Session03_Guide.html)

> **نبذة عن المشروع:** 📘 [01 C# Basics - Session 03] String Immutability, String Intern Pool (ReferenceEquals), StringBuilder, Switch Jump Tables, Loops & Early Return Guards (18 Solved Questions + Interactive HTML Guide).

---

## 🌐 الدليل التفاعلي المشروح بالـ HTML (Interactive Study Guide)

تم تضمين الدليل التفاعلي المشروح بالكامل داخل مجلد [`Study_Guide/`](./Study_Guide) في هذا المستودع، ويمكنك قراءته مباشرة في المتصفح عبر الروابط التالية:

- 🌐 الدليل التفاعلي الشامل لـ Session 03 (HTML): **[🌐 معاينة حية في المتصفح (Live Preview)](https://htmlpreview.github.io/?https://github.com/mohamedadel452/CSharp-Basics03-Assigment/blob/master/Study_Guide/CSharp_Basics_Session03_Guide.html)** | **[📄 فتح ملف الـ HTML في المستودع](./Study_Guide/CSharp_Basics_Session03_Guide.html)**
- 📂 **[فتح مجلد المحاضرة المحلي الكامل في `nots` (للتصفح المحلي على الجهاز)](../../../../nots/01_CSharp-Basics/Session_03_ControlFlow_Loops_&_Strings)**

---

### 🧠 الملاحظات الهندسية والمفاهيم المعمارية (Engineering Notes)
1. **عدم قابلية النصوص للتعديل (`String Immutability`) وجدول `String Intern Pool`:**
   - النصوص في `.NET` هي كائنات مرجعية غير قابلة للتعديل؛ استدعاء `title.ToUpper()` ينشئ كائناً نصياً جديداً في الـ `Heap` ولا يمس النص الأصلي.
   - **String Interning:** النصوص الثابتة المتطابقة في الكود المصدري (`"Clean Code"`) يتم توحيدها بواسطة الـ CLR في جدول `Intern Pool` لتشير لنفس العنوان، مما يجعل `object.ReferenceEquals(str1, str2)` ترجع `true`. أما إنشاء نص في وقت التشغيل عبر `new string("Clean Code".ToCharArray())` فيحجز عنواناً جديداً في الـ `Heap` وترجع `ReferenceEquals` القيمة `false`.
2. **معمارية `StringBuilder` للتعديلات المتكررة:**
   - بدلاً من إنشاء كائن نصي جديد مع كل عملية دمج، يحتفظ `StringBuilder` بمصفوفة حروف داخلية قابلة للتمدد (`char[] Chunk`)، مما يجعل عمليات `Append` و `Replace` تتم في نفس المكان (`In-Place`) بكفاءة عالية دون إجهاد الـ Garbage Collector.
3. **جمل التحكم (`if/else`, `switch`, Ternary `?:`) والحلقات التكرارية:**
   - تطبيق التقييم القصير (`Short-Circuit Evaluation`) عبر `&&`.
   - مقارنة الحلقات الأربع (`for`, `while`, `do-while`, `foreach`) والتحكم في مسار التنفيذ عبر `break` و `continue`.
   - تطبيق نمط **Guard Clause (Early Return)** في الدالة `PrintFirstBook` لفحص `null` والمصفوفة الفارغة قبل الوصول للعنصر الأول.

---

## 🗂️ هيكلة الكود والتمارين التطبيقية المحلولة

| الأسئلة | المفهوم الهندسي | التطبيق في الكود |
| :--- | :--- | :--- |
| **Q1 – Q2** | String Immutability & Intern Pool | تطبيق `ToUpper()` وفحص مراجع الذاكرة عبر `object.ReferenceEquals`. |
| **Q3 – Q4** | `StringBuilder` (`Append` & `Replace`) | بناء نص متغير وتحديثه في الذاكرة بدون تخصيص كائنات زائدة. |
| **Q5 – Q7** | String Formatting (`+`, `$"{}"`, `string.Format`) | مقارنة الطرق الثلاث لبناء الجمل النصية المركبة. |
| **Q8 – Q11** | Conditional Logic (`if/else`, `&&`, `switch`, `?:`) | تصنيف حجم الكتاب وفحص الإتاحة واختيار التوصيات عبر `switch`. |
| **Q12 – Q15** | Loops (`for`, `while`, `do-while`, `foreach`) | طباعة عناصر مصفوفة الكتب بأربع طرق تكرارية مختلفة. |
| **Q16 – Q18** | `break`, `continue` & Early Return Guard Clause | التحكم في القفز داخل الحلقات، وحماية دالة `PrintFirstBook` من `null` والمصفوفة الفارغة. |

---

## 🧭 خريطة مسار هندسة `.NET` الكامل على GitHub

| # | المرحلة (Module) | المستودع (Repository) | الموضوع الرئيسي | الدليل التفاعلي (Live HTML) |
| :---: | :--- | :--- | :--- | :---: |
| **01** | `01_CSharp_Basics` | **[`CSharp-Basics02-Assigment`](https://github.com/mohamedadel452/CSharp-Basics02-Assigment)** | أنواع البيانات، نموذج الكائنات (System.Object)، والتحويلات | [🌐 فتح الشرح التفاعلي](https://htmlpreview.github.io/?https://github.com/mohamedadel452/CSharp-Basics02-Assigment/blob/master/Study_Guide/CSharp_Basics_Session02_Guide.html) |
| **02** | `01_CSharp_Basics` | **[`CSharp-Basics03-Assigment`](https://github.com/mohamedadel452/CSharp-Basics03-Assigment)** | معمارية النصوص (Strings & StringBuilder)، جمل التحكم، والحلقات | [🌐 فتح الشرح التفاعلي](https://htmlpreview.github.io/?https://github.com/mohamedadel452/CSharp-Basics03-Assigment/blob/master/Study_Guide/CSharp_Basics_Session03_Guide.html) |
| **03** | `01_CSharp_Basics` | **[`CSharp-Basics04-Assigment`](https://github.com/mohamedadel452/CSharp-Basics04-Assigment)** | المصفوفات (1D & 2D Arrays) وتمرير المعاملات للدوال (Value / ref / out / params) | [🌐 فتح الشرح التفاعلي](https://htmlpreview.github.io/?https://github.com/mohamedadel452/CSharp-Basics04-Assigment/blob/master/Study_Guide/CSharp_Basics_Session04_Guide.html) |
| **04** | `01_CSharp_Basics` | **[`CSharp-Basics05-Assigment`](https://github.com/mohamedadel452/CSharp-Basics05-Assigment)** | محددات الوصول (Access Modifiers)، التغليف، والـ Enums | [🌐 فتح الشرح التفاعلي](https://htmlpreview.github.io/?https://github.com/mohamedadel452/CSharp-Basics05-Assigment/blob/master/Study_Guide/CSharp_Basics_Session05_Guide.html) |
| **05** | `02_OOP` | **[`OOP-Session-01-Assigment`](https://github.com/mohamedadel452/OOP-Session-01-Assigment)** | الـ Struct، التغليف، الخصائص، والـ Indexers (نظام Smart Delivery) | [🌐 فتح الشرح التفاعلي](https://htmlpreview.github.io/?https://github.com/mohamedadel452/OOP-Session-01-Assigment/blob/master/Study_Guide/OOP_Session01_Deep_Dive.html) |
| **06** | `02_OOP` | **[`OOP-Session-02-Assigment`](https://github.com/mohamedadel452/OOP-Session-02-Assigment)** | الفئات (Classes)، الوراثة، وتسلسل الـ Constructors (Smart Delivery Part 1) | [🌐 فتح الشرح التفاعلي](https://htmlpreview.github.io/?https://github.com/mohamedadel452/OOP-Session-02-Assigment/blob/master/Study_Guide/OOP_Session02_Deep_Dive.html) |
| **07** | `02_OOP` | **[`OOP-Session-03-Assigment`](https://github.com/mohamedadel452/OOP-Session-03-Assigment)** | تعدد الأشكال (Polymorphism)، الربط الديناميكي، والكلاسات المختومة (Sealed) | [🌐 فتح الشرح التفاعلي](https://htmlpreview.github.io/?https://github.com/mohamedadel452/OOP-Session-03-Assigment/blob/master/Study_Guide/OOP_Session03_04_Dispatch_&_SOLID_Deep_Dive.html) |
| **08** | `02_OOP` | **[`OOP-Session-04-Assigment`](https://github.com/mohamedadel452/OOP-Session-04-Assigment)** | التجريد (Abstraction)، الفئات المجردة، والواجهات (Smart Delivery Part 3) | [🌐 فتح الشرح التفاعلي](https://htmlpreview.github.io/?https://github.com/mohamedadel452/OOP-Session-04-Assigment/blob/master/Study_Guide/OOP_Session04_Deep_Dive.html) |
| **09** | `02_OOP` | **[`OOP-Session-05-Assigment`](https://github.com/mohamedadel452/OOP-Session-05-Assigment)** | نسخ الكائنات، Static، دوال التوسيع، والـ Partial Classes (Smart Delivery Final) | [🌐 فتح الشرح التفاعلي](https://htmlpreview.github.io/?https://github.com/mohamedadel452/OOP-Session-05-Assigment/blob/master/Study_Guide/OOP_Session05_Deep_Dive.html) |
| **10** | `03_Advanced_CSharp` | **[`Advanced-CSharp-01`](https://github.com/mohamedadel452/Advanced-CSharp-01)** | الأنواع المعممة (Generics)، القيود (Constraints)، والـ Variance | [🌐 فتح الشرح التفاعلي](https://htmlpreview.github.io/?https://github.com/mohamedadel452/Advanced-CSharp-01/blob/master/Study_Guide/Generics_Deep_Part1_Core.html) |
| **11** | `03_Advanced_CSharp` | **[`Advanced-CSharp-02`](https://github.com/mohamedadel452/Advanced-CSharp-02)** | المفوضات (Delegates)، تعبيرات Lambda، ونظام ShopMaster | [🌐 فتح الشرح التفاعلي](https://htmlpreview.github.io/?https://github.com/mohamedadel452/Advanced-CSharp-02/blob/master/Study_Guide/Delegates_Part1_Core.html) |
| **12** | `03_Advanced_CSharp` | **[`Advanced-CSharp-03`](https://github.com/mohamedadel452/Advanced-CSharp-03)** | معمارية هياكل البيانات والـ Collections (6 أنظمة تطبيقية) | [🌐 فتح الشرح التفاعلي](https://htmlpreview.github.io/?https://github.com/mohamedadel452/Advanced-CSharp-03/blob/master/Study_Guide/session03-part1-collections-list.html) |
| **13** | `04_Database` | **[`Database-Session-01-Assigment`](https://github.com/mohamedadel452/Database-Session-01-Assigment)** | تصميم قواعد البيانات، مخططات الـ ERD، والتحويل العلائقي (Relational Mapping) | [🌐 فتح الشرح التفاعلي](https://htmlpreview.github.io/?https://github.com/mohamedadel452/Database-Session-01-Assigment/blob/master/Study_Guide/ERD_Part1_Design_Intro.html) |

---

## 🚀 طريقة التشغيل المحلي (How to Run)

```bash
git clone https://github.com/mohamedadel452/CSharp-Basics03-Assigment.git
cd CSharp-Basics03-Assigment
dotnet run --project "C#-Basics03-Assigment/C#-Basics03-Assigment.csproj"
```

**إعداد وتطوير:** [محمد عادل محمد بيومي (mohamedadel452)](https://github.com/mohamedadel452) — كلية الحاسبات والمعلومات، جامعة عين شمس.

</div>
