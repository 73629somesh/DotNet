namespace notification;

public static class NotificationService{

    public static void sendSms(string to,string content){
        Console.WriteLine(to+" "+content);
    }

    public static void sendEmail(string to,string content){
        Console.WriteLine(to+" "+content);
    }
    public static void sendWhatsupMsg(string to, string content){
        Console.WriteLine(to+" "+content);
    }
}