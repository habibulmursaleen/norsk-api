﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NorskApi.Infrastructure.Persistance.DBContext;

#nullable disable

namespace NorskApi.Infrastructure.Migrations
{
    [DbContext(typeof(NorskApiDbContext))]
    partial class NorskApiDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Essay", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Activities")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("DifficultyLevel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsCompleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsSaved")
                        .HasColumnType("bit");

                    b.Property<string>("Label")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Logo")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Notes")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<double>("Progress")
                        .HasColumnType("float");

                    b.Property<string>("RelatedGrammarTopicIds")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tags")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedDateTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Essays", (string)null);
                });

            modelBuilder.Entity("NorskApi.Domain.DictationAggregate.Dictation", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Answer")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("DifficultyLevel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("EssayId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsCompleted")
                        .HasColumnType("bit");

                    b.Property<string>("Label")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime>("UpdatedDateTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Dictations", (string)null);
                });

            modelBuilder.Entity("NorskApi.Domain.DiscussionAggregate.Discussion", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("DifficultyLevel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DiscussionEssays")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<Guid>("EssayId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsCompleted")
                        .HasColumnType("bit");

                    b.Property<string>("Note")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime>("UpdatedDateTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Discussions", (string)null);
                });

            modelBuilder.Entity("NorskApi.Domain.GrammarTopicAggregate.GrammarTopic", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("Chapter")
                        .HasColumnType("float");

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("DifficultyLevel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsCompleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsSaved")
                        .HasColumnType("bit");

                    b.Property<string>("Label")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<double>("ModuleCount")
                        .HasColumnType("float");

                    b.Property<double>("Progress")
                        .HasColumnType("float");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tags")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedDateTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("GrammarTopics", (string)null);
                });

            modelBuilder.Entity("NorskApi.Domain.GrammmarRuleAggregate.GrammarRule", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AdditionalInformation")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Comments")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("DifficultyLevel")
                        .HasColumnType("int");

                    b.Property<string>("ExplanatoryNotes")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Label")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("RelatedRuleIds")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RuleType")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("SentenceStructure")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tags")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("TopicId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("UpdatedDateTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("GrammarRules", (string)null);
                });

            modelBuilder.Entity("NorskApi.Domain.LocalExpressionAggregate.LocalExpression", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Label")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("LocalExpressionType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MeaningInEnglish")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("MeaningInNorsk")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<DateTime>("UpdatedDateTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("LocalExpressions", (string)null);
                });

            modelBuilder.Entity("NorskApi.Domain.PodcastAggregate.Podcast", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descriptions")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("DifficultyLevel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("EssayId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsCompleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsFeatured")
                        .HasColumnType("bit");

                    b.Property<string>("Label")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Logo")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime>("UpdatedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.ToTable("Podcasts", (string)null);
                });

            modelBuilder.Entity("NorskApi.Domain.QuestionAggregate.Question", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Answer")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("DifficultyLevel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("EssayId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsCompleted")
                        .HasColumnType("bit");

                    b.Property<string>("Label")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime>("UpdatedDateTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Questions", (string)null);
                });

            modelBuilder.Entity("NorskApi.Domain.QuizAggregate.Quiz", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Answer")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("DictationId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DifficultyLevel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("EssayId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsRightAnswer")
                        .HasColumnType("bit");

                    b.Property<string>("Question")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("QuizType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("TopicId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("UpdatedDateTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Quizzes", (string)null);
                });

            modelBuilder.Entity("NorskApi.Domain.RoleplayAggregate.Roleplay", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("DifficultyLevel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("EssayId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsCompleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("UpdatedDateTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Roleplays", (string)null);
                });

            modelBuilder.Entity("NorskApi.Domain.SubjunctionAgreegate.Subjunction", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Arsak")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Betingelse")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Hensikt")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Motsetning")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Time")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedDateTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Subjunctions", (string)null);
                });

            modelBuilder.Entity("NorskApi.Domain.TaskWorkAggregate.TaskWork", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AdditionalInfo")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Answer")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Comments")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("DifficultyLevel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsCompleted")
                        .HasColumnType("bit");

                    b.Property<string>("Label")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Logo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TaskPointer")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<Guid>("TopicId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("UpdatedDateTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("TaskWorks", (string)null);
                });

            modelBuilder.Entity("Essay", b =>
                {
                    b.OwnsMany("NorskApi.Domain.EssayAggregate.Entities.Paragraph", "Paragraphs", b1 =>
                        {
                            b1.Property<Guid>("Id")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<string>("Content")
                                .IsRequired()
                                .HasMaxLength(255)
                                .HasColumnType("nvarchar(255)");

                            b1.Property<string>("ContentType")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<DateTime>("CreatedDateTime")
                                .HasColumnType("datetime2");

                            b1.Property<Guid>("EssayId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<string>("Title")
                                .HasMaxLength(255)
                                .HasColumnType("nvarchar(255)");

                            b1.Property<DateTime>("UpdatedDateTime")
                                .HasColumnType("datetime2");

                            b1.HasKey("Id");

                            b1.HasIndex("EssayId");

                            b1.ToTable("Paragraphs", (string)null);

                            b1.WithOwner()
                                .HasForeignKey("EssayId");
                        });

                    b.Navigation("Paragraphs");
                });

            modelBuilder.Entity("NorskApi.Domain.GrammmarRuleAggregate.GrammarRule", b =>
                {
                    b.OwnsMany("NorskApi.Domain.GrammmarRuleAggregate.Entites.ExampleOfRule", "ExampleOfRules", b1 =>
                        {
                            b1.Property<Guid>("Id")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<string>("Adverbial")
                                .HasMaxLength(255)
                                .HasColumnType("nvarchar(255)");

                            b1.Property<string>("CorrectSentence")
                                .HasMaxLength(255)
                                .HasColumnType("nvarchar(255)");

                            b1.Property<DateTime>("CreatedDateTime")
                                .HasColumnType("datetime2");

                            b1.Property<string>("EnglishSentence")
                                .HasMaxLength(255)
                                .HasColumnType("nvarchar(255)");

                            b1.Property<Guid>("GrammarRuleId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<Guid>("GrammarRuleId_FK")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<string>("IncorrectSentence")
                                .HasMaxLength(255)
                                .HasColumnType("nvarchar(255)");

                            b1.Property<string>("Object")
                                .HasMaxLength(255)
                                .HasColumnType("nvarchar(255)");

                            b1.Property<string>("Rest")
                                .HasMaxLength(255)
                                .HasColumnType("nvarchar(255)");

                            b1.Property<string>("Subject")
                                .HasMaxLength(255)
                                .HasColumnType("nvarchar(255)");

                            b1.Property<string>("Subjunction")
                                .HasMaxLength(255)
                                .HasColumnType("nvarchar(255)");

                            b1.Property<string>("TransformationFrom")
                                .HasMaxLength(255)
                                .HasColumnType("nvarchar(255)");

                            b1.Property<string>("TransformationTo")
                                .HasMaxLength(255)
                                .HasColumnType("nvarchar(255)");

                            b1.Property<DateTime>("UpdatedDateTime")
                                .HasColumnType("datetime2");

                            b1.Property<string>("Verb")
                                .HasMaxLength(255)
                                .HasColumnType("nvarchar(255)");

                            b1.HasKey("Id");

                            b1.HasIndex("GrammarRuleId");

                            b1.ToTable("ExampleOfRules", (string)null);

                            b1.WithOwner()
                                .HasForeignKey("GrammarRuleId");
                        });

                    b.OwnsMany("NorskApi.Domain.GrammmarRuleAggregate.Entites.Exception", "Exceptions", b1 =>
                        {
                            b1.Property<Guid>("Id")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<string>("Comments")
                                .HasMaxLength(255)
                                .HasColumnType("nvarchar(255)");

                            b1.Property<string>("CorrectSentence")
                                .HasMaxLength(255)
                                .HasColumnType("nvarchar(255)");

                            b1.Property<DateTime>("CreatedDateTime")
                                .HasColumnType("datetime2");

                            b1.Property<string>("Description")
                                .HasMaxLength(255)
                                .HasColumnType("nvarchar(255)");

                            b1.Property<Guid>("GrammarRuleId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<Guid>("GrammarRuleId_FK")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<string>("IncorrectSentence")
                                .HasMaxLength(255)
                                .HasColumnType("nvarchar(255)");

                            b1.Property<string>("Title")
                                .HasMaxLength(255)
                                .HasColumnType("nvarchar(255)");

                            b1.Property<DateTime>("UpdatedDateTime")
                                .HasColumnType("datetime2");

                            b1.HasKey("Id");

                            b1.HasIndex("GrammarRuleId");

                            b1.ToTable("Exceptions", (string)null);

                            b1.WithOwner()
                                .HasForeignKey("GrammarRuleId");
                        });

                    b.Navigation("ExampleOfRules");

                    b.Navigation("Exceptions");
                });

            modelBuilder.Entity("NorskApi.Domain.QuizAggregate.Quiz", b =>
                {
                    b.OwnsMany("NorskApi.Domain.QuizAggregate.Entites.QuizOption", "QuizOptions", b1 =>
                        {
                            b1.Property<Guid>("Id")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<DateTime>("CreatedDateTime")
                                .HasColumnType("datetime2");

                            b1.Property<bool>("IsCorrect")
                                .HasColumnType("bit");

                            b1.Property<bool?>("MultipleChoiceAnswer")
                                .IsRequired()
                                .HasColumnType("bit");

                            b1.Property<Guid>("QuizId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<string>("Title")
                                .IsRequired()
                                .HasMaxLength(255)
                                .HasColumnType("nvarchar(255)");

                            b1.Property<DateTime>("UpdatedDateTime")
                                .HasColumnType("datetime2");

                            b1.HasKey("Id");

                            b1.HasIndex("QuizId");

                            b1.ToTable("QuizOptions", (string)null);

                            b1.WithOwner()
                                .HasForeignKey("QuizId");
                        });

                    b.Navigation("QuizOptions");
                });
#pragma warning restore 612, 618
        }
    }
}
