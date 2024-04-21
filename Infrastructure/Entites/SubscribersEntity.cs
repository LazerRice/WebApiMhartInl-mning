using System.ComponentModel.DataAnnotations;

namespace Infrastructure.Entites;

public class SubscribersEntity
{
	[Key]
	public string Email { get; set; } = null!;
	public bool DailyNewsletter { get; set; }
	public bool AdvertisingUpdate { get; set; }
	public bool WeekinReview { get; set; }
	public bool EventUpdates { get; set; }
	public bool StartupsWeekly { get; set; }
	public bool Podcasts { get; set; }
}
