using banking ;
using System.Threading;
using taxation;
using notification;

// Account acc=new Account();
// acc.Balance=5000;

// acc.deposit(1200);

// NotificationOperation proxySmsSender=new NotificationOperation(NotificationService.sendSms);
// NotificationOperation proxyEmailSender=new NotificationOperation(NotificationService.sendEmail);

// NotificationOperation proxy=null;

// proxy+=proxyEmailSender;
// proxy+=proxySmsSender;

// proxy("somesh","how are you");

Account acc1=new Account();

acc1.underbalance+=NotificationService.sendEmail;
acc1.Balance=5000;
acc1.deposit(2000);
