using System.ComponentModel.DataAnnotations;
using Delegate;

class Program 
{
	static void Main()
	{
		// create objek youtuber, email, notification, subscriber
		Youtuber youtuber= new Youtuber();
		Email email= new Email();
		Notification notification= new Notification();
		Subscriber subscriber= new Subscriber();
		
		youtuber.email=email;
		youtuber.subscriber=subscriber;
		youtuber.notification=notification;
		
		youtuber.UploadVideo();
	}
}