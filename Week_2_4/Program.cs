using Week_2_4.Entities;

Console.WriteLine("Calendar App");

new Meeting() { Title = "Learnship İçerik Üreticiliği Yiğit", Details = new List<string> { "Çekilen  videolar editlenecek", "Yeni video fikirleri düşülünecek", "Fikirlker genişletilecek" }, StartTime = new DateTime(2023, 9, 25, 12, 30, 0), FinishTime = new DateTime(2023, 9, 25, 13, 30, 0), Guests = new() { "yigit@gmail.com" } }.GetNotification();

new Todo() { Title = "Rentco Aws Cognito", Details = new List<string> { "E-posta ayarlanacak", "SenderId ayarlancak", "API geliştirilecek" }, StartTime = new DateTime(2023, 9, 25, 14, 0, 0), FinishTime = new DateTime(2023, 9, 25, 18, 29, 0), Importance = "High Priority"}.GetNotification();