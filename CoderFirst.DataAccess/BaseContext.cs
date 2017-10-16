using Microsoft.EntityFrameworkCore;
using CoderFirst.DataAccess.Model;
using CoderFirst.DataAccess.Model.Member;
using CoderFirst.DataAccess.Model.Content;
using CoderFirst.DataAccess.Model.Meetup;
using CoderFirst.DataAccess.Model.App;
using CoderFirst.DataAccess.Model.Email;
using CoderFirst.DataAccess.Model.Job;
using CoderFirst.DataAccess.Model.Job.Lookup;

namespace CoderFirst.DataAccess
{
    public class BaseContext : DbContext
    {


        public BaseContext(DbContextOptions<BaseContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }

        public DbSet<Post> Post { get; set; }
        public DbSet<EmailTemplate> EmailTemplate { get; set; }
        public DbSet<Job> Job { get; set; }
        public DbSet<EmailList> EmailList { get; set; }
        public DbSet<EmailAddress> EmailAddress { get; set; }
        public DbSet<JobApplication> JobApplication { get; set; }
        public DbSet<Member> Member { get; set; }
        public DbSet<SkillTag> SkillTag { get; set; }
        public DbSet<JobInSkill> JobInSkill { get; set; }
        public DbSet<Subscription> Subscription { get; set; }
        public DbSet<TopicTag> TopicTag { get; set; }
        public DbSet<Blog> Blog { get; set; }
        public DbSet<PostLike> PostLike { get; set; }
        public DbSet<Advertisment> Advertisment { get; set; }
        public DbSet<SocialContact> SocialContact { get; set; }
        public DbSet<PostComment> PostComment { get; set; }
        public DbSet<MeetupComment> MeetupComment { get; set; }
        public DbSet<InvalidEmail> InvalidEmail { get; set; }
        public DbSet<Like> Like { get; set; }
        public DbSet<Contact> Contact { get; set; }
        public DbSet<Meetup> Meetup { get; set; }
        public DbSet<EmailUnsubscription> EmailUnsubscription { get; set; }
        public DbSet<MeetupParticipant> MeetupParticipant { get; set; }
    }
}
