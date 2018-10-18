﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using cloudscribe.SimpleContent.Models;
using cloudscribe.SimpleContent.Storage.EFCore.PostgreSql;

namespace cloudscribe.SimpleContent.Storage.EFCore.PostgreSql.Migrations
{
    [DbContext(typeof(SimpleContentDbContext))]
    partial class SimpleContentDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.1.3-rtm-32065")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("cloudscribe.SimpleContent.Models.ContentHistory", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasMaxLength(36);

                    b.Property<string>("ArchivedBy")
                        .HasColumnName("archived_by")
                        .HasMaxLength(255);

                    b.Property<DateTime>("ArchivedUtc")
                        .HasColumnName("archived_utc");

                    b.Property<string>("Author")
                        .HasColumnName("author")
                        .HasMaxLength(255);

                    b.Property<string>("CategoriesCsv")
                        .HasColumnName("categories_csv");

                    b.Property<string>("Content")
                        .HasColumnName("content");

                    b.Property<string>("ContentId")
                        .IsRequired()
                        .HasColumnName("content_id")
                        .HasMaxLength(36);

                    b.Property<string>("ContentSource")
                        .IsRequired()
                        .HasColumnName("content_source")
                        .HasMaxLength(50);

                    b.Property<string>("ContentType")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("content_type")
                        .HasMaxLength(50)
                        .HasDefaultValue("html");

                    b.Property<string>("CorrelationKey")
                        .HasColumnName("correlation_key")
                        .HasMaxLength(255);

                    b.Property<string>("CreatedByUser")
                        .HasColumnName("created_by_user")
                        .HasMaxLength(100);

                    b.Property<DateTime>("CreatedUtc")
                        .HasColumnName("created_utc");

                    b.Property<string>("DraftAuthor")
                        .HasColumnName("draft_author")
                        .HasMaxLength(255);

                    b.Property<string>("DraftContent")
                        .HasColumnName("draft_content");

                    b.Property<DateTime?>("DraftPubDate")
                        .HasColumnName("draft_pub_date");

                    b.Property<string>("DraftSerializedModel")
                        .HasColumnName("draft_serialized_model");

                    b.Property<bool>("IsDraftHx")
                        .HasColumnName("is_draft_hx");

                    b.Property<bool>("IsPublished")
                        .HasColumnName("is_published");

                    b.Property<DateTime>("LastModified")
                        .HasColumnName("last_modified");

                    b.Property<string>("LastModifiedByUser")
                        .HasColumnName("last_modified_by_user")
                        .HasMaxLength(100);

                    b.Property<string>("MetaDescription")
                        .HasColumnName("meta_description");

                    b.Property<string>("MetaHtml")
                        .HasColumnName("meta_html");

                    b.Property<string>("MetaJson")
                        .HasColumnName("meta_json");

                    b.Property<int>("PageOrder")
                        .HasColumnName("page_order");

                    b.Property<string>("ParentId")
                        .HasColumnName("parent_id")
                        .HasMaxLength(255);

                    b.Property<string>("ParentSlug")
                        .HasColumnName("parent_slug")
                        .HasMaxLength(255);

                    b.Property<string>("ProjectId")
                        .HasColumnName("project_id");

                    b.Property<DateTime?>("PubDate")
                        .HasColumnName("pub_date");

                    b.Property<string>("SerializedModel")
                        .HasColumnName("serialized_model");

                    b.Property<string>("Serializer")
                        .HasColumnName("serializer")
                        .HasMaxLength(50);

                    b.Property<string>("Slug")
                        .HasColumnName("slug")
                        .HasMaxLength(255);

                    b.Property<string>("TeaserOverride")
                        .HasColumnName("teaser_override");

                    b.Property<string>("TemplateKey")
                        .HasColumnName("template_key")
                        .HasMaxLength(255);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnName("title")
                        .HasMaxLength(255);

                    b.Property<string>("ViewRoles")
                        .HasColumnName("view_roles");

                    b.Property<bool>("WasDeleted")
                        .HasColumnName("was_deleted");

                    b.HasKey("Id")
                        .HasName("pk_cs_content_history");

                    b.HasIndex("ContentId")
                        .HasName("ix_cs_content_history_content_id");

                    b.HasIndex("ContentSource")
                        .HasName("ix_cs_content_history_content_source");

                    b.HasIndex("CorrelationKey")
                        .HasName("ix_cs_content_history_correlation_key");

                    b.HasIndex("CreatedByUser")
                        .HasName("ix_cs_content_history_created_by_user");

                    b.HasIndex("LastModifiedByUser")
                        .HasName("ix_cs_content_history_last_modified_by_user");

                    b.HasIndex("Title")
                        .HasName("ix_cs_content_history_title");

                    b.ToTable("cs_content_history");
                });

            modelBuilder.Entity("cloudscribe.SimpleContent.Models.ProjectSettings", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasMaxLength(36);

                    b.Property<bool>("AddBlogToPagesTree")
                        .HasColumnName("add_blog_to_pages_tree");

                    b.Property<bool>("BlogMenuLinksToNewestPost")
                        .HasColumnName("blog_menu_links_to_newest_post");

                    b.Property<string>("BlogPageNavComponentVisibility")
                        .HasColumnName("blog_page_nav_component_visibility")
                        .HasMaxLength(255);

                    b.Property<int>("BlogPagePosition")
                        .HasColumnName("blog_page_position");

                    b.Property<string>("BlogPageText")
                        .HasColumnName("blog_page_text")
                        .HasMaxLength(255);

                    b.Property<string>("CdnUrl")
                        .HasColumnName("cdn_url")
                        .HasMaxLength(255);

                    b.Property<string>("ChannelCategoriesCsv")
                        .HasColumnName("channel_categories_csv")
                        .HasMaxLength(255);

                    b.Property<string>("ChannelRating")
                        .HasColumnName("channel_rating")
                        .HasMaxLength(100);

                    b.Property<int>("ChannelTimeToLive")
                        .HasColumnName("channel_time_to_live");

                    b.Property<string>("CommentNotificationEmail")
                        .HasColumnName("comment_notification_email")
                        .HasMaxLength(100);

                    b.Property<string>("CopyrightNotice")
                        .HasColumnName("copyright_notice")
                        .HasMaxLength(255);

                    b.Property<int>("DaysToComment")
                        .HasColumnName("days_to_comment");

                    b.Property<string>("DefaultContentType")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("default_content_type")
                        .HasMaxLength(50)
                        .HasDefaultValue("html");

                    b.Property<int>("DefaultFeedItems")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("default_feed_items")
                        .HasDefaultValue(20);

                    b.Property<string>("DefaultPageSlug")
                        .HasColumnName("default_page_slug")
                        .HasMaxLength(255);

                    b.Property<string>("Description")
                        .HasColumnName("description");

                    b.Property<string>("DisqusShortName")
                        .HasColumnName("disqus_short_name")
                        .HasMaxLength(100);

                    b.Property<string>("FacebookAppId")
                        .HasColumnName("facebook_app_id")
                        .HasMaxLength(100);

                    b.Property<string>("Image")
                        .HasColumnName("image")
                        .HasMaxLength(255);

                    b.Property<bool>("IncludePubDateInPostUrls")
                        .HasColumnName("include_pub_date_in_post_urls");

                    b.Property<string>("LanguageCode")
                        .HasColumnName("language_code")
                        .HasMaxLength(10);

                    b.Property<string>("LocalMediaVirtualPath")
                        .HasColumnName("local_media_virtual_path")
                        .HasMaxLength(255);

                    b.Property<string>("ManagingEditorEmail")
                        .HasColumnName("managing_editor_email")
                        .HasMaxLength(100);

                    b.Property<int>("MaxFeedItems")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("max_feed_items")
                        .HasDefaultValue(1000);

                    b.Property<bool>("ModerateComments")
                        .HasColumnName("moderate_comments");

                    b.Property<int>("PostsPerPage")
                        .HasColumnName("posts_per_page");

                    b.Property<string>("PubDateFormat")
                        .HasColumnName("pub_date_format")
                        .HasMaxLength(75);

                    b.Property<string>("Publisher")
                        .HasColumnName("publisher")
                        .HasMaxLength(255);

                    b.Property<string>("PublisherEntityType")
                        .HasColumnName("publisher_entity_type")
                        .HasMaxLength(50);

                    b.Property<string>("PublisherLogoHeight")
                        .HasColumnName("publisher_logo_height")
                        .HasMaxLength(20);

                    b.Property<string>("PublisherLogoUrl")
                        .HasColumnName("publisher_logo_url")
                        .HasMaxLength(255);

                    b.Property<string>("PublisherLogoWidth")
                        .HasColumnName("publisher_logo_width")
                        .HasMaxLength(20);

                    b.Property<string>("RecaptchaPrivateKey")
                        .HasColumnName("recaptcha_private_key")
                        .HasMaxLength(255);

                    b.Property<string>("RecaptchaPublicKey")
                        .HasColumnName("recaptcha_public_key")
                        .HasMaxLength(255);

                    b.Property<string>("RemoteFeedProcessorUseAgentFragment")
                        .HasColumnName("remote_feed_processor_use_agent_fragment")
                        .HasMaxLength(255);

                    b.Property<string>("RemoteFeedUrl")
                        .HasColumnName("remote_feed_url")
                        .HasMaxLength(255);

                    b.Property<bool>("ShowFeaturedPostsOnDefaultPage")
                        .HasColumnName("show_featured_posts_on_default_page");

                    b.Property<bool>("ShowRecentPostsOnDefaultPage")
                        .HasColumnName("show_recent_posts_on_default_page");

                    b.Property<bool>("ShowTitle")
                        .HasColumnName("show_title");

                    b.Property<string>("SiteName")
                        .HasColumnName("site_name")
                        .HasMaxLength(200);

                    b.Property<byte>("TeaserMode")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("teaser_mode")
                        .HasDefaultValue((byte)0);

                    b.Property<int>("TeaserTruncationLength")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("teaser_truncation_length")
                        .HasDefaultValue(20);

                    b.Property<byte>("TeaserTruncationMode")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("teaser_truncation_mode")
                        .HasDefaultValue((byte)0);

                    b.Property<string>("TimeZoneId")
                        .HasColumnName("time_zone_id")
                        .HasMaxLength(100);

                    b.Property<string>("Title")
                        .HasColumnName("title")
                        .HasMaxLength(255);

                    b.Property<string>("TwitterCreator")
                        .HasColumnName("twitter_creator")
                        .HasMaxLength(100);

                    b.Property<string>("TwitterPublisher")
                        .HasColumnName("twitter_publisher")
                        .HasMaxLength(100);

                    b.Property<bool>("UseDefaultPageAsRootNode")
                        .HasColumnName("use_default_page_as_root_node");

                    b.Property<string>("WebmasterEmail")
                        .HasColumnName("webmaster_email")
                        .HasMaxLength(100);

                    b.HasKey("Id")
                        .HasName("pk_cs_content_project");

                    b.ToTable("cs_content_project");
                });

            modelBuilder.Entity("cloudscribe.SimpleContent.Storage.EFCore.Models.PageCategory", b =>
                {
                    b.Property<string>("Value")
                        .HasColumnName("value")
                        .HasMaxLength(50);

                    b.Property<string>("PageEntityId")
                        .HasColumnName("page_entity_id")
                        .HasMaxLength(36);

                    b.Property<string>("ProjectId")
                        .IsRequired()
                        .HasColumnName("project_id")
                        .HasMaxLength(36);

                    b.HasKey("Value", "PageEntityId")
                        .HasName("pk_cs_page_category");

                    b.HasIndex("PageEntityId")
                        .HasName("ix_cs_page_category_page_entity_id");

                    b.HasIndex("ProjectId")
                        .HasName("ix_cs_page_category_project_id");

                    b.HasIndex("Value")
                        .HasName("ix_cs_page_category_value");

                    b.ToTable("cs_page_category");
                });

            modelBuilder.Entity("cloudscribe.SimpleContent.Storage.EFCore.Models.PageComment", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasMaxLength(36);

                    b.Property<string>("Author")
                        .HasColumnName("author")
                        .HasMaxLength(255);

                    b.Property<string>("Content")
                        .HasColumnName("content");

                    b.Property<string>("Email")
                        .HasColumnName("email")
                        .HasMaxLength(100);

                    b.Property<string>("Ip")
                        .HasColumnName("ip")
                        .HasMaxLength(100);

                    b.Property<bool>("IsAdmin")
                        .HasColumnName("is_admin");

                    b.Property<bool>("IsApproved")
                        .HasColumnName("is_approved");

                    b.Property<string>("PageEntityId")
                        .HasColumnName("page_entity_id")
                        .HasMaxLength(36);

                    b.Property<string>("ProjectId")
                        .IsRequired()
                        .HasColumnName("project_id")
                        .HasMaxLength(36);

                    b.Property<DateTime>("PubDate")
                        .HasColumnName("pub_date");

                    b.Property<string>("UserAgent")
                        .HasColumnName("user_agent")
                        .HasMaxLength(255);

                    b.Property<string>("Website")
                        .HasColumnName("website")
                        .HasMaxLength(255);

                    b.HasKey("Id")
                        .HasName("pk_cs_page_comment");

                    b.HasIndex("PageEntityId")
                        .HasName("ix_cs_page_comment_page_entity_id");

                    b.HasIndex("ProjectId")
                        .HasName("ix_cs_page_comment_project_id");

                    b.ToTable("cs_page_comment");
                });

            modelBuilder.Entity("cloudscribe.SimpleContent.Storage.EFCore.Models.PageEntity", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasMaxLength(36);

                    b.Property<string>("Author")
                        .HasColumnName("author")
                        .HasMaxLength(255);

                    b.Property<string>("CategoriesCsv")
                        .HasColumnName("categories_csv")
                        .HasMaxLength(500);

                    b.Property<string>("Content")
                        .HasColumnName("content");

                    b.Property<string>("ContentType")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("content_type")
                        .HasMaxLength(50)
                        .HasDefaultValue("html");

                    b.Property<string>("CorrelationKey")
                        .HasColumnName("correlation_key")
                        .HasMaxLength(255);

                    b.Property<string>("CreatedByUser")
                        .HasColumnName("created_by_user")
                        .HasMaxLength(100);

                    b.Property<DateTime>("CreatedUtc")
                        .HasColumnName("created_utc");

                    b.Property<bool>("DisableEditor")
                        .HasColumnName("disable_editor");

                    b.Property<string>("DraftAuthor")
                        .HasColumnName("draft_author")
                        .HasMaxLength(255);

                    b.Property<string>("DraftContent")
                        .HasColumnName("draft_content");

                    b.Property<DateTime?>("DraftPubDate")
                        .HasColumnName("draft_pub_date");

                    b.Property<string>("DraftSerializedModel")
                        .HasColumnName("draft_serialized_model");

                    b.Property<string>("ExternalUrl")
                        .HasColumnName("external_url")
                        .HasMaxLength(255);

                    b.Property<bool>("IsPublished")
                        .HasColumnName("is_published");

                    b.Property<DateTime>("LastModified")
                        .HasColumnName("last_modified");

                    b.Property<string>("LastModifiedByUser")
                        .HasColumnName("last_modified_by_user")
                        .HasMaxLength(100);

                    b.Property<string>("MenuFilters")
                        .HasColumnName("menu_filters")
                        .HasMaxLength(500);

                    b.Property<bool>("MenuOnly")
                        .HasColumnName("menu_only");

                    b.Property<string>("MetaDescription")
                        .HasColumnName("meta_description")
                        .HasMaxLength(500);

                    b.Property<string>("MetaHtml")
                        .HasColumnName("meta_html");

                    b.Property<string>("MetaJson")
                        .HasColumnName("meta_json");

                    b.Property<int>("PageOrder")
                        .HasColumnName("page_order");

                    b.Property<string>("ParentId")
                        .HasColumnName("parent_id")
                        .HasMaxLength(36);

                    b.Property<string>("ParentSlug")
                        .HasColumnName("parent_slug")
                        .HasMaxLength(255);

                    b.Property<string>("ProjectId")
                        .IsRequired()
                        .HasColumnName("project_id")
                        .HasMaxLength(36);

                    b.Property<DateTime?>("PubDate")
                        .HasColumnName("pub_date");

                    b.Property<string>("SerializedModel")
                        .HasColumnName("serialized_model");

                    b.Property<string>("Serializer")
                        .HasColumnName("serializer")
                        .HasMaxLength(50);

                    b.Property<bool>("ShowCategories")
                        .HasColumnName("show_categories");

                    b.Property<bool>("ShowComments")
                        .HasColumnName("show_comments");

                    b.Property<bool>("ShowHeading")
                        .HasColumnName("show_heading");

                    b.Property<bool>("ShowLastModified")
                        .HasColumnName("show_last_modified");

                    b.Property<bool>("ShowMenu")
                        .HasColumnName("show_menu");

                    b.Property<bool>("ShowPubDate")
                        .HasColumnName("show_pub_date");

                    b.Property<string>("Slug")
                        .IsRequired()
                        .HasColumnName("slug")
                        .HasMaxLength(255);

                    b.Property<string>("TemplateKey")
                        .HasColumnName("template_key")
                        .HasMaxLength(255);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnName("title")
                        .HasMaxLength(255);

                    b.Property<string>("ViewRoles")
                        .HasColumnName("view_roles");

                    b.HasKey("Id")
                        .HasName("pk_cs_page");

                    b.HasIndex("CorrelationKey")
                        .HasName("ix_cs_page_correlation_key");

                    b.HasIndex("ParentId")
                        .HasName("ix_cs_page_parent_id");

                    b.HasIndex("ProjectId")
                        .HasName("ix_cs_page_project_id");

                    b.ToTable("cs_page");
                });

            modelBuilder.Entity("cloudscribe.SimpleContent.Storage.EFCore.Models.PageResourceEntity", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasMaxLength(36);

                    b.Property<string>("Environment")
                        .IsRequired()
                        .HasColumnName("environment")
                        .HasMaxLength(15);

                    b.Property<string>("PageEntityId")
                        .HasColumnName("page_entity_id")
                        .HasMaxLength(36);

                    b.Property<int>("Sort")
                        .HasColumnName("sort");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnName("type")
                        .HasMaxLength(10);

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnName("url")
                        .HasMaxLength(255);

                    b.HasKey("Id")
                        .HasName("pk_cs_page_resource");

                    b.HasIndex("PageEntityId")
                        .HasName("ix_cs_page_resource_page_entity_id");

                    b.ToTable("cs_page_resource");
                });

            modelBuilder.Entity("cloudscribe.SimpleContent.Storage.EFCore.Models.PostCategory", b =>
                {
                    b.Property<string>("Value")
                        .HasColumnName("value")
                        .HasMaxLength(50);

                    b.Property<string>("PostEntityId")
                        .HasColumnName("post_entity_id")
                        .HasMaxLength(36);

                    b.Property<string>("ProjectId")
                        .IsRequired()
                        .HasColumnName("project_id")
                        .HasMaxLength(36);

                    b.HasKey("Value", "PostEntityId")
                        .HasName("pk_cs_post_category");

                    b.HasIndex("PostEntityId")
                        .HasName("ix_cs_post_category_post_entity_id");

                    b.HasIndex("ProjectId")
                        .HasName("ix_cs_post_category_project_id");

                    b.HasIndex("Value")
                        .HasName("ix_cs_post_category_value");

                    b.ToTable("cs_post_category");
                });

            modelBuilder.Entity("cloudscribe.SimpleContent.Storage.EFCore.Models.PostComment", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasMaxLength(36);

                    b.Property<string>("Author")
                        .HasColumnName("author")
                        .HasMaxLength(255);

                    b.Property<string>("Content")
                        .HasColumnName("content");

                    b.Property<string>("Email")
                        .HasColumnName("email")
                        .HasMaxLength(100);

                    b.Property<string>("Ip")
                        .HasColumnName("ip")
                        .HasMaxLength(100);

                    b.Property<bool>("IsAdmin")
                        .HasColumnName("is_admin");

                    b.Property<bool>("IsApproved")
                        .HasColumnName("is_approved");

                    b.Property<string>("PostEntityId")
                        .HasColumnName("post_entity_id")
                        .HasMaxLength(36);

                    b.Property<string>("ProjectId")
                        .IsRequired()
                        .HasColumnName("project_id")
                        .HasMaxLength(36);

                    b.Property<DateTime>("PubDate")
                        .HasColumnName("pub_date");

                    b.Property<string>("UserAgent")
                        .HasColumnName("user_agent")
                        .HasMaxLength(255);

                    b.Property<string>("Website")
                        .HasColumnName("website")
                        .HasMaxLength(255);

                    b.HasKey("Id")
                        .HasName("pk_cs_post_comment");

                    b.HasIndex("PostEntityId")
                        .HasName("ix_cs_post_comment_post_entity_id");

                    b.HasIndex("ProjectId")
                        .HasName("ix_cs_post_comment_project_id");

                    b.ToTable("cs_post_comment");
                });

            modelBuilder.Entity("cloudscribe.SimpleContent.Storage.EFCore.Models.PostEntity", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasMaxLength(36);

                    b.Property<string>("Author")
                        .HasColumnName("author")
                        .HasMaxLength(255);

                    b.Property<string>("AutoTeaser")
                        .HasColumnName("auto_teaser");

                    b.Property<string>("BlogId")
                        .IsRequired()
                        .HasColumnName("blog_id")
                        .HasMaxLength(36);

                    b.Property<string>("CategoriesCsv")
                        .HasColumnName("categories_csv")
                        .HasMaxLength(500);

                    b.Property<string>("Content")
                        .HasColumnName("content");

                    b.Property<string>("ContentType")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("content_type")
                        .HasMaxLength(50)
                        .HasDefaultValue("html");

                    b.Property<string>("CorrelationKey")
                        .HasColumnName("correlation_key")
                        .HasMaxLength(255);

                    b.Property<string>("CreatedByUser")
                        .HasColumnName("created_by_user")
                        .HasMaxLength(100);

                    b.Property<DateTime>("CreatedUtc")
                        .HasColumnName("created_utc");

                    b.Property<string>("DraftAuthor")
                        .HasColumnName("draft_author")
                        .HasMaxLength(255);

                    b.Property<string>("DraftContent")
                        .HasColumnName("draft_content");

                    b.Property<DateTime?>("DraftPubDate")
                        .HasColumnName("draft_pub_date");

                    b.Property<string>("DraftSerializedModel")
                        .HasColumnName("draft_serialized_model");

                    b.Property<string>("ImageUrl")
                        .HasColumnName("image_url")
                        .HasMaxLength(250);

                    b.Property<bool>("IsFeatured")
                        .HasColumnName("is_featured");

                    b.Property<bool>("IsPublished")
                        .HasColumnName("is_published");

                    b.Property<DateTime>("LastModified")
                        .HasColumnName("last_modified");

                    b.Property<string>("LastModifiedByUser")
                        .HasColumnName("last_modified_by_user")
                        .HasMaxLength(100);

                    b.Property<string>("MetaDescription")
                        .HasColumnName("meta_description")
                        .HasMaxLength(500);

                    b.Property<string>("MetaHtml")
                        .HasColumnName("meta_html");

                    b.Property<string>("MetaJson")
                        .HasColumnName("meta_json");

                    b.Property<DateTime?>("PubDate")
                        .HasColumnName("pub_date");

                    b.Property<string>("SerializedModel")
                        .HasColumnName("serialized_model");

                    b.Property<string>("Serializer")
                        .HasColumnName("serializer")
                        .HasMaxLength(50);

                    b.Property<string>("Slug")
                        .IsRequired()
                        .HasColumnName("slug")
                        .HasMaxLength(255);

                    b.Property<bool>("SuppressTeaser")
                        .HasColumnName("suppress_teaser");

                    b.Property<string>("TeaserOverride")
                        .HasColumnName("teaser_override");

                    b.Property<string>("TemplateKey")
                        .HasColumnName("template_key")
                        .HasMaxLength(255);

                    b.Property<string>("ThumbnailUrl")
                        .HasColumnName("thumbnail_url")
                        .HasMaxLength(250);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnName("title")
                        .HasMaxLength(255);

                    b.HasKey("Id")
                        .HasName("pk_cs_post");

                    b.HasIndex("BlogId")
                        .HasName("ix_cs_post_blog_id");

                    b.HasIndex("CorrelationKey")
                        .HasName("ix_cs_post_correlation_key");

                    b.HasIndex("Slug")
                        .HasName("ix_cs_post_slug");

                    b.ToTable("cs_post");
                });

            modelBuilder.Entity("cloudscribe.SimpleContent.Storage.EFCore.Models.PageComment", b =>
                {
                    b.HasOne("cloudscribe.SimpleContent.Storage.EFCore.Models.PageEntity")
                        .WithMany("PageComments")
                        .HasForeignKey("PageEntityId")
                        .HasConstraintName("fk_cs_page_comment_cs_page_page_entity_id");
                });

            modelBuilder.Entity("cloudscribe.SimpleContent.Storage.EFCore.Models.PageResourceEntity", b =>
                {
                    b.HasOne("cloudscribe.SimpleContent.Storage.EFCore.Models.PageEntity")
                        .WithMany("PageResources")
                        .HasForeignKey("PageEntityId")
                        .HasConstraintName("fk_cs_page_resource_cs_page_page_entity_id");
                });

            modelBuilder.Entity("cloudscribe.SimpleContent.Storage.EFCore.Models.PostComment", b =>
                {
                    b.HasOne("cloudscribe.SimpleContent.Storage.EFCore.Models.PostEntity")
                        .WithMany("PostComments")
                        .HasForeignKey("PostEntityId")
                        .HasConstraintName("fk_cs_post_comment_cs_post_post_entity_id");
                });
#pragma warning restore 612, 618
        }
    }
}