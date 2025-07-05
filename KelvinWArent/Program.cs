using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Exceptions;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;

class Program
{
    private static readonly string token = "8094469779:AAE_XjNqJBDDBYDngpNdTYdmYlSZkk9EthU";
    private static readonly long ownerId = 1343912508; // ID владельца бота
    private static readonly TelegramBotClient botClient = new TelegramBotClient(token);
    private static readonly Queue<string> numbers = new Queue<string>();
    private static readonly Dictionary<string, string> userNumbers = new Dictionary<string, string>();
    private static string? lastUploadedPhotoId;
    // Объявление словаря для хранения пользователей
    // Объявляем словарь с long в качестве ключа
    private static Dictionary<long, string> pendingCodeUsers = new Dictionary<long, string>();


    static async Task Main()
    {
        var me = await botClient.GetMeAsync();
        Console.WriteLine($"Бот {me.FirstName} запущен!");

        botClient.StartReceiving(UpdateHandler, ErrorHandler);

        Console.ReadLine();
    }

    private static async Task UpdateHandler(ITelegramBotClient bot, Update update, CancellationToken cancellationToken)
    {
        if (update.Type == UpdateType.Message && update.Message != null)
        {
            var message = update.Message;
            var chatId = message.Chat.Id;
            var username = message.From?.Username ?? "Unknown";

            if (message.Text == "/start")
            {
                var keyboard = new ReplyKeyboardMarkup(new[]
                {
                    new KeyboardButton[] { "Добавить номер", "Статистика", }
                })
                { ResizeKeyboard = true };

                await bot.SendTextMessageAsync(chatId, "Выберите действие:", replyMarkup: keyboard);
            }
           else if(message.Text == "/startDev")
            {
                var DevKeyboard = new ReplyKeyboardMarkup(new[]
                 {
                    new KeyboardButton[] { "Взять номер из очереди", "Статистика",}
                })
                { ResizeKeyboard = true };
                await bot.SendTextMessageAsync(chatId, "Выберите действие(DevMod):", replyMarkup: DevKeyboard);
            }
            else if (message.Text == "Добавить номер")
            {
                await bot.SendTextMessageAsync(chatId, "Введите номер телефона:");
            }
            else if (message.Text == "Статистика")
            {
                string response = numbers.Count > 0 ? $"Всего номеров: {numbers.Count}\n" : "Список номеров пуст.";
                await bot.SendTextMessageAsync(chatId, response);
            }
            else if (message.Text == "Взять номер из очереди")
            {
                string response = numbers.Count > 0 ? $"Взят номер: {numbers.Dequeue()}\n" : "Список номеров пуст.";
                await bot.SendTextMessageAsync(chatId, response);
            }
            else if (message.Text != null && (message.Text.StartsWith("+") || message.Text.All(char.IsDigit)))
            {
                numbers.Enqueue(message.Text);
                userNumbers[username] = message.Text;
                await bot.SendTextMessageAsync(chatId, "Номер сохранен!");

                // Уведомление владельца
                var adminKeyboard = new InlineKeyboardMarkup(new[]
                {
        new[]
        {
            InlineKeyboardButton.WithCallbackData("Встал", "stood_up"),
            InlineKeyboardButton.WithCallbackData("Скинуть код", $"send_code_{username}"),
            InlineKeyboardButton.WithCallbackData("Слет", "failed")
        }
    });

                await bot.SendTextMessageAsync(ownerId, $"Пользователь @{username} добавил номер: {message.Text}", replyMarkup: adminKeyboard);
            }

            else
            {
                await bot.SendTextMessageAsync(chatId, "Я не понимаю этот запрос.");
                await bot.SendTextMessageAsync(647146889, "Вот это сисечки");

            }
        }
        else if (update.Type == UpdateType.CallbackQuery)
        {
            var callbackQuery = update.CallbackQuery;
            var callbackData = callbackQuery.Data;
            var adminChatId = callbackQuery.Message.Chat.Id;

            if (callbackData.StartsWith("send_code_"))
            {

                var username = callbackData.Replace("send_code_", "");
                pendingCodeUsers[callbackQuery.From.Id] = username; // Ждем фото от владельца

                await bot.SendTextMessageAsync(adminChatId,
                    $"📸 Отправьте фото, которое нужно передать пользователю @{username}");
                if (userNumbers.TryGetValue(username, out var userNumber))
                {
                    if (lastUploadedPhotoId != null)
                    {
                        await bot.SendPhotoAsync(userNumber, lastUploadedPhotoId, 123);
                    }
                    else
                    {
                        await bot.SendTextMessageAsync(adminChatId, "Фото не загружено.");
                    }
                }
            }
        }
        else if (update.Type == UpdateType.Message && update.Message.Photo != null)
        {
            lastUploadedPhotoId = update.Message.Photo.Last().FileId;
            await bot.SendTextMessageAsync(update.Message.Chat.Id, "Фото сохранено.");
        }
    }

    private static Task ErrorHandler(ITelegramBotClient bot, Exception exception, CancellationToken cancellationToken)
    {
        Console.WriteLine($"Ошибка: {exception.Message}");
        return Task.CompletedTask;
    }
}
