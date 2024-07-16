namespace Delegate;

// create class youtuber
public class Youtuber
{
	// create 
	public Subscriber subscriber;
	public Notification notification; 
	public Email email;
	

	// create method Upload Video
	public void UploadVideo()
	{
		// print upload video
		Console.WriteLine("Upload Video");
		// print this title when youtuber upload video
		SentNotification("please watch this new video");
	}
	// create method send notification
	public void SentNotification(string title)
	{
		// print notifikasi
		Console.WriteLine(notification);
		subscriber.ShowVideo(title);
		notification.ShowDetail(title);
		email.ShowText(title);
	}
	
}
