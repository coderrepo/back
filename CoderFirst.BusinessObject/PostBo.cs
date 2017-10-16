using System;
using System.Collections.Generic;
using CoderFirst.Common.Enum;

namespace CoderFirst.BusinessObject
{
    public class PostBo
    {
       public int PostId { get; set; }
       public Guid PostGuid { get; set; }
       public Guid MemberGuid { get; set; }
       public string PostUrl { get; set; }
       public string FriendlyUrl { get; set; }
       public string Title { get; set; }
        public string Description { get; set; }
       public string BlogContent { get; set; }
       public string ImageUrl { get; set; }
       public string JobTitle { get; set; }
       public int ImageWidth { get; set; }
       public int ImageHeight { get; set; }
       public string CompanyName { get; set; }
       public string PostTypeText { get; set; }
        
       public int TotalLike { get; set; }
       public int TotalView { get; set; }
       public string UserName { get; set; }
       public string ReadMoreUrl { get; set; }
       public string ProfileUrl { get; set; }
       public PostPublishStatusEnum PostStatus { get; set; }
       public string[] PostTags { get; set; }
       public string Tags { get; set; }
       public string MemberName { get; set; }
       public string MemberJobTitle { get; set; }
       public DateTime LastModified { get; set; }
       public DateTime PublishedOn { get; set; }
       public int MemberId { get; set; }
       public string MemberPhotoUrl { get; set; }
       public bool IsPostLiked { get; set; }
       public bool NoImageSelected { get; set; }
       public PostTypeEnum PostType { get; set; }
       public bool CanLoadInIFrame { get; set; }
       public PostImagePositionEnum PostImagePosition { get; set; }
       public int PostImageWidth { get; set; }
       public int PostImageHeight { get; set; }
       public bool IsDraftSaved { get; set; }
       public bool IsPreview { get; set; }
       public string PostTypeName { get; set; }
       public string PostStatusName { get; set; }
       public string[] BlogImages { get; set; }
       public string Email { get; set; }
       public string MemberEmail { get; set; }
       public string VideoEmbed { get; set; }
    }

    public class PostCustomBo
    {
        public Guid PostGuid { get; set; }
        public int PostId { get; set; }
        public string ProfileUrl { get; set; }
        public string ReadMoreUrl { get; set; }
        public string Title { get; set; }
        public string ImageUrl { get; set; }
        public bool Liked { get; set; }
        public int TotalLike { get; set; }
        public int TotalView { get; set; }
        public List<string> PostTags { get; set; }
        public string MemberName { get; set; }
        public string MemberPhotoUrl { get; set; }
        public DateTime PublishedOn { get; set; }
        public Guid MemberGuid { get; set; }
        public string Description { get; set; }
        public string PublishedOnText { get; set; }
        public  PostImagePositionEnum PostImagePosition { get; set; }
        public int PostImageWidth { get; set; }
        public int PostImageHeight { get; set; }
        public string PostTypeName { get; set; }

        public bool CanLoadInIFrame { get; set; }
        public string PostUrl { get; set; }

        public string VideoEmbed { get; set; }
        public string Tag { get; set; }
        public string JobTitle { get; set; }
    }

}
