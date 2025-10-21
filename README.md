# ✅ Tasker – Blazor To-Do App

**Tasker** is a lightweight and elegant **task manager** built with **Blazor Server** and **Bootstrap 5**.  
It demonstrates how to build reusable components, manage state, and create interactive UIs in Blazor with a modern and responsive design.

---

## 🖼️ Preview

Example of a task item component:

```razor
<div class="hstack task-item">
    <div>
        <InputCheckbox class="form-check-input" @bind-Value="Item.IsComplete" @bind-Value:after="updateItem" />
    </div>
    <div class="px-2 flex-grow-1">
        <p class="p-0 m-0 task @(Item.IsComplete ? "complete animate" : "")">@Item.Name</p>
    </div>
    <div>
        <button class="btn btn-icon btn-transparent text-danger gradient-hover" @onclick="deleteItem">
            <i class="bi bi-trash-fill" />
        </button>
    </div>
</div>
````

---

## ✨ Features

* ✅ Add, update, and delete tasks
* 🧠 Track completion state (`IsComplete`)
* 🎞️ Smooth animation when marking tasks complete
* 💅 Beautiful, responsive UI using **Bootstrap 5**
* ⚙️ Modular architecture with **Blazor components**
* 💾 Local storage persistence support (via JS Interop or future WASM storage)

---

## 📁 Project Structure

```
Tasker/
│
├── Components
│       ├── Pages/
│       │     └── Index.razor              # Main page showing task list
│       ├── UI/
│       │   ├── TaskItem.razor             # Reusable component for each task
|       |   └── PrioritySelector.razor     #Reusable component for setting priority to model
│       ├── Layout/
│           ├── MainLayout.razor           # MainLayout including nav bar and etc
|           └── NavMenu.razor              # Nav menu of all project in layouts 
│
├── Models/
│   ├── TaskerItem.cs                      # Task model class
|   └── GlobalEnums.cs                     # Global enums for project
│
├── wwwroot/
│   └── css/
│       └── site.css                       # Custom CSS (animations, gradients, etc.)
│
└── Program.cs                             # Blazor Server setup
```

---

## 🚀 Getting Started

### 1. Clone the repository

```bash
git clone https://github.com/YasinSadjadi/BlazorTasker.git
cd BlazorTasker
```

### 2. Restore dependencies

```bash
dotnet restore
```

### 3. Run the app

```bash
dotnet run
```

### 4. Open in browser

Navigate to 👉 `https://localhost:7289`

---

## ⚙️ Tech Stack

* **.NET 8 / Blazor Server**
* **C#**
* **Bootstrap 5**
* **Razor Components**

---

## 🎨 UI Design Notes

* Custom animations for task completion (`.animate` and `.complete` classes)
* Transparent delete button with gradient hover effect
* Minimal and clean task layout using `hstack` from Bootstrap utilities

---

## 🧠 Future Improvements

* [ ] Local storage or database persistence
* [ ] Task categories
* [ ] Due date and reminders
* [ ] Dark / light theme toggle
* [ ] PWA support

---

## 📄 License

This project is open source and available under the **MIT License**.

---

## 👨‍💻 Author

**Yasin Sadjadi**
📎 GitHub: [github.com/YasinSadjadi](https://github.com/YasinSadjadi)
💬 Feel free to contribute or open issues for new ideas!
