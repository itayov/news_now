﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NewsNow.Models;

namespace NewsNow.Migrations
{
    [DbContext(typeof(NewsNowContext))]
    [Migration("20181031191331_SavtaShli")]
    partial class SavtaShli
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("NewsNow.Models.Article", b =>
                {
                    b.Property<int>("ArticleId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId");

                    b.Property<string>("Content");

                    b.Property<DateTime?>("DateCreated");

                    b.Property<string>("Header");

                    b.Property<string>("HomeImageUrl");

                    b.Property<bool>("IsShowMap");

                    b.Property<string>("Location");

                    b.Property<string>("Summery");

                    b.HasKey("ArticleId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Articles");

                    b.HasData(
                        new { ArticleId = 1, CategoryId = 1, Content = @"This is an example article with multiple paragraphs, **bolds**, *""quotes""* and others.


example paragraph
--

The statement from attorneys Debra Katz, Lisa Banks and Michael Bromwich came after a call Sunday with staff for the Senate Judiciary Committee. Kavanaugh has denied the allegations and said he wants to testify before the committee.

*""Despite actual threats to her safety and her life, Dr. Ford believes it is important for Senators to hear directly from her about the sexual assault committed against her,""* the statement read.

paragraph with image
--
*""We stand with the Iranian people against the scourge of radical Islamic terrorism and express our sympathy to them at this terrible time,""* she said Saturday.

The parade was part of nationwide celebrations in Iran to mark the 30th anniversary of the end of its eight-year war with Iraq.
Gunmen opened fire on armed forces marching inside a park as well as spectators who had gathered to watch the parade, Iranian armed forces spokesman Brig. Gen. Abolfazl Shekarchi told Mehr, a semi-official Iranian news agency.
All four attackers were killed during clashes with security forces, IRNA reported, citing the deputy governor-general of Khuzestan province, where the attack happened.

![](https://cdn.cnn.com/cnnnext/dam/assets/180922044651-iran-parade-attack-09-22-18-exlarge-169.jpg)
*Injured soldiers lie on the ground after Saturday's attack on a military parade Ahvaz, Iran.*

*""The terrorists disguised as Islamic Revolution Guards Corps and Basij (volunteer) forces opened fire to the authority and people from behind the stand during the parade,""* said Gholam-Reza Shariati, governor of Khuzestan province, according to IRNA.
Khuzestan is a province that borders Iraq and has a large ethnic Arab community, many of them Sunni. It was a major battleground during the Iran-Iraq War that killed half a million soldiers in the '80s.
", DateCreated = new DateTime(2018, 5, 1, 8, 30, 52, 0, DateTimeKind.Unspecified), Header = "Iran blames US and Saudi Arabia for terror attack", HomeImageUrl = "https://images.jpost.com/image/upload/f_auto,fl_lossy/t_Article2016_ControlFaceDetect/427101", IsShowMap = true, Location = "טהרן, אירן", Summery = "Iran blames the US and Saudi Arabia for military parade terror attack" },
                        new { ArticleId = 2, CategoryId = 2, Content = @"This is an example article with multiple paragraphs, **bolds**, *""quotes""* and others.


example paragraph
--

The statement from attorneys Debra Katz, Lisa Banks and Michael Bromwich came after a call Sunday with staff for the Senate Judiciary Committee. Kavanaugh has denied the allegations and said he wants to testify before the committee.

*""Despite actual threats to her safety and her life, Dr. Ford believes it is important for Senators to hear directly from her about the sexual assault committed against her,""* the statement read.

paragraph with image
--
*""We stand with the Iranian people against the scourge of radical Islamic terrorism and express our sympathy to them at this terrible time,""* she said Saturday.

The parade was part of nationwide celebrations in Iran to mark the 30th anniversary of the end of its eight-year war with Iraq.
Gunmen opened fire on armed forces marching inside a park as well as spectators who had gathered to watch the parade, Iranian armed forces spokesman Brig. Gen. Abolfazl Shekarchi told Mehr, a semi-official Iranian news agency.
All four attackers were killed during clashes with security forces, IRNA reported, citing the deputy governor-general of Khuzestan province, where the attack happened.

![](https://cdn.cnn.com/cnnnext/dam/assets/180922044651-iran-parade-attack-09-22-18-exlarge-169.jpg)
*Injured soldiers lie on the ground after Saturday's attack on a military parade Ahvaz, Iran.*

*""The terrorists disguised as Islamic Revolution Guards Corps and Basij (volunteer) forces opened fire to the authority and people from behind the stand during the parade,""* said Gholam-Reza Shariati, governor of Khuzestan province, according to IRNA.
Khuzestan is a province that borders Iraq and has a large ethnic Arab community, many of them Sunni. It was a major battleground during the Iran-Iraq War that killed half a million soldiers in the '80s.
", DateCreated = new DateTime(2018, 8, 7, 5, 22, 23, 0, DateTimeKind.Unspecified), Header = "Gilad Erdan: Israel making progress against Terror", HomeImageUrl = "https://images.jpost.com/image/upload/f_auto,fl_lossy/t_TopStoryMainImageFaceDetect/429944", IsShowMap = false, Location = "תל אביב, ישראל", Summery = "Erdan is responsible for the fight against BDS in the Strategic Affairs Ministry, and the steps he has taken in that battle are controversial and unconventional." },
                        new { ArticleId = 3, CategoryId = 1, Content = @"This is an example article with multiple paragraphs, **bolds**, *""quotes""* and others.


example paragraph
--

The statement from attorneys Debra Katz, Lisa Banks and Michael Bromwich came after a call Sunday with staff for the Senate Judiciary Committee. Kavanaugh has denied the allegations and said he wants to testify before the committee.

*""Despite actual threats to her safety and her life, Dr. Ford believes it is important for Senators to hear directly from her about the sexual assault committed against her,""* the statement read.

paragraph with image
--
*""We stand with the Iranian people against the scourge of radical Islamic terrorism and express our sympathy to them at this terrible time,""* she said Saturday.

The parade was part of nationwide celebrations in Iran to mark the 30th anniversary of the end of its eight-year war with Iraq.
Gunmen opened fire on armed forces marching inside a park as well as spectators who had gathered to watch the parade, Iranian armed forces spokesman Brig. Gen. Abolfazl Shekarchi told Mehr, a semi-official Iranian news agency.
All four attackers were killed during clashes with security forces, IRNA reported, citing the deputy governor-general of Khuzestan province, where the attack happened.

![](https://cdn.cnn.com/cnnnext/dam/assets/180922044651-iran-parade-attack-09-22-18-exlarge-169.jpg)
*Injured soldiers lie on the ground after Saturday's attack on a military parade Ahvaz, Iran.*

*""The terrorists disguised as Islamic Revolution Guards Corps and Basij (volunteer) forces opened fire to the authority and people from behind the stand during the parade,""* said Gholam-Reza Shariati, governor of Khuzestan province, according to IRNA.
Khuzestan is a province that borders Iraq and has a large ethnic Arab community, many of them Sunni. It was a major battleground during the Iran-Iraq War that killed half a million soldiers in the '80s.
", DateCreated = new DateTime(2018, 3, 7, 2, 22, 23, 0, DateTimeKind.Unspecified), Header = "Russia: We were mislead by israel", HomeImageUrl = "https://images.haarets.co.il/image/upload/w_2184,h_1270,x_0,y_75,c_crop,g_north_west/w_857,h_482,q_auto,c_fill,f_auto/fl_any_format.preserve_transparency.progressive:none/v1537691679/1.6494059.1232180831.jpg", IsShowMap = true, Location = "תל אביב, ישראל", Summery = "Maj. Gen. Igor Konashenkov, chief spokesman for the Russian Ministry of Defense, said that Israeli strikes in Syria put Russian forces there at risk." },
                        new { ArticleId = 4, CategoryId = 1, Content = @"This is an example article with multiple paragraphs, **bolds**, *""quotes""* and others.


example paragraph
--

The statement from attorneys Debra Katz, Lisa Banks and Michael Bromwich came after a call Sunday with staff for the Senate Judiciary Committee. Kavanaugh has denied the allegations and said he wants to testify before the committee.

*""Despite actual threats to her safety and her life, Dr. Ford believes it is important for Senators to hear directly from her about the sexual assault committed against her,""* the statement read.

paragraph with image
--
*""We stand with the Iranian people against the scourge of radical Islamic terrorism and express our sympathy to them at this terrible time,""* she said Saturday.

The parade was part of nationwide celebrations in Iran to mark the 30th anniversary of the end of its eight-year war with Iraq.
Gunmen opened fire on armed forces marching inside a park as well as spectators who had gathered to watch the parade, Iranian armed forces spokesman Brig. Gen. Abolfazl Shekarchi told Mehr, a semi-official Iranian news agency.
All four attackers were killed during clashes with security forces, IRNA reported, citing the deputy governor-general of Khuzestan province, where the attack happened.

![](https://cdn.cnn.com/cnnnext/dam/assets/180922044651-iran-parade-attack-09-22-18-exlarge-169.jpg)
*Injured soldiers lie on the ground after Saturday's attack on a military parade Ahvaz, Iran.*

*""The terrorists disguised as Islamic Revolution Guards Corps and Basij (volunteer) forces opened fire to the authority and people from behind the stand during the parade,""* said Gholam-Reza Shariati, governor of Khuzestan province, according to IRNA.
Khuzestan is a province that borders Iraq and has a large ethnic Arab community, many of them Sunni. It was a major battleground during the Iran-Iraq War that killed half a million soldiers in the '80s.
", DateCreated = new DateTime(2018, 10, 6, 11, 10, 2, 0, DateTimeKind.Unspecified), Header = "Israel rejects russian claims: IAF did not hide behind russian plane", HomeImageUrl = "https://www.jpost.com/HttpHandlers/ShowImage.ashx?id=350908&w=898&h=628", IsShowMap = false, Location = "תל אביב, ישראל", Summery = "The IAF did not hide behind any plane and Israeli fighter jets were in Israeli airspace when the Syrians attacked the Russian plane" },
                        new { ArticleId = 5, CategoryId = 1, Content = @"This is an example article with multiple paragraphs, **bolds**, *""quotes""* and others.


example paragraph
--

The statement from attorneys Debra Katz, Lisa Banks and Michael Bromwich came after a call Sunday with staff for the Senate Judiciary Committee. Kavanaugh has denied the allegations and said he wants to testify before the committee.

*""Despite actual threats to her safety and her life, Dr. Ford believes it is important for Senators to hear directly from her about the sexual assault committed against her,""* the statement read.

paragraph with image
--
*""We stand with the Iranian people against the scourge of radical Islamic terrorism and express our sympathy to them at this terrible time,""* she said Saturday.

The parade was part of nationwide celebrations in Iran to mark the 30th anniversary of the end of its eight-year war with Iraq.
Gunmen opened fire on armed forces marching inside a park as well as spectators who had gathered to watch the parade, Iranian armed forces spokesman Brig. Gen. Abolfazl Shekarchi told Mehr, a semi-official Iranian news agency.
All four attackers were killed during clashes with security forces, IRNA reported, citing the deputy governor-general of Khuzestan province, where the attack happened.

![](https://cdn.cnn.com/cnnnext/dam/assets/180922044651-iran-parade-attack-09-22-18-exlarge-169.jpg)
*Injured soldiers lie on the ground after Saturday's attack on a military parade Ahvaz, Iran.*

*""The terrorists disguised as Islamic Revolution Guards Corps and Basij (volunteer) forces opened fire to the authority and people from behind the stand during the parade,""* said Gholam-Reza Shariati, governor of Khuzestan province, according to IRNA.
Khuzestan is a province that borders Iraq and has a large ethnic Arab community, many of them Sunni. It was a major battleground during the Iran-Iraq War that killed half a million soldiers in the '80s.
", DateCreated = new DateTime(2017, 12, 11, 11, 10, 2, 0, DateTimeKind.Unspecified), Header = "U.S. Terror victomsm ask Trump: bar Abbas", HomeImageUrl = "https://images.jpost.com/image/upload/f_auto,fl_lossy/t_Article2016_ControlFaceDetect/428957", IsShowMap = false, Location = "תל אביב, ישראל", Summery = "The family members called the decision to allow Abbas’s entry to the US \"a slap in the face to every American who has suffered from terror.\"" },
                        new { ArticleId = 6, CategoryId = 5, Content = @"This is an example article with multiple paragraphs, **bolds**, *""quotes""* and others.


example paragraph
--

The statement from attorneys Debra Katz, Lisa Banks and Michael Bromwich came after a call Sunday with staff for the Senate Judiciary Committee. Kavanaugh has denied the allegations and said he wants to testify before the committee.

*""Despite actual threats to her safety and her life, Dr. Ford believes it is important for Senators to hear directly from her about the sexual assault committed against her,""* the statement read.

paragraph with image
--
*""We stand with the Iranian people against the scourge of radical Islamic terrorism and express our sympathy to them at this terrible time,""* she said Saturday.

The parade was part of nationwide celebrations in Iran to mark the 30th anniversary of the end of its eight-year war with Iraq.
Gunmen opened fire on armed forces marching inside a park as well as spectators who had gathered to watch the parade, Iranian armed forces spokesman Brig. Gen. Abolfazl Shekarchi told Mehr, a semi-official Iranian news agency.
All four attackers were killed during clashes with security forces, IRNA reported, citing the deputy governor-general of Khuzestan province, where the attack happened.

![](https://cdn.cnn.com/cnnnext/dam/assets/180922044651-iran-parade-attack-09-22-18-exlarge-169.jpg)
*Injured soldiers lie on the ground after Saturday's attack on a military parade Ahvaz, Iran.*

*""The terrorists disguised as Islamic Revolution Guards Corps and Basij (volunteer) forces opened fire to the authority and people from behind the stand during the parade,""* said Gholam-Reza Shariati, governor of Khuzestan province, according to IRNA.
Khuzestan is a province that borders Iraq and has a large ethnic Arab community, many of them Sunni. It was a major battleground during the Iran-Iraq War that killed half a million soldiers in the '80s.
", DateCreated = new DateTime(2017, 3, 8, 11, 10, 2, 0, DateTimeKind.Unspecified), Header = "Trails and Tribulations of Eurovision 2019, What to expect next?", HomeImageUrl = "https://images.jpost.com/image/upload/f_auto,fl_lossy/t_Article2016_ControlFaceDetect/429094", IsShowMap = false, Location = "תל אביב, ישראל", Summery = "For the next eight months, squabbles over politics, money and religion are bound to plague the upcoming Eurovision. But which arguments should be taken seriously?" },
                        new { ArticleId = 7, CategoryId = 5, Content = @"This is an example article with multiple paragraphs, **bolds**, *""quotes""* and others.


example paragraph
--

The statement from attorneys Debra Katz, Lisa Banks and Michael Bromwich came after a call Sunday with staff for the Senate Judiciary Committee. Kavanaugh has denied the allegations and said he wants to testify before the committee.

*""Despite actual threats to her safety and her life, Dr. Ford believes it is important for Senators to hear directly from her about the sexual assault committed against her,""* the statement read.

paragraph with image
--
*""We stand with the Iranian people against the scourge of radical Islamic terrorism and express our sympathy to them at this terrible time,""* she said Saturday.

The parade was part of nationwide celebrations in Iran to mark the 30th anniversary of the end of its eight-year war with Iraq.
Gunmen opened fire on armed forces marching inside a park as well as spectators who had gathered to watch the parade, Iranian armed forces spokesman Brig. Gen. Abolfazl Shekarchi told Mehr, a semi-official Iranian news agency.
All four attackers were killed during clashes with security forces, IRNA reported, citing the deputy governor-general of Khuzestan province, where the attack happened.

![](https://cdn.cnn.com/cnnnext/dam/assets/180922044651-iran-parade-attack-09-22-18-exlarge-169.jpg)
*Injured soldiers lie on the ground after Saturday's attack on a military parade Ahvaz, Iran.*

*""The terrorists disguised as Islamic Revolution Guards Corps and Basij (volunteer) forces opened fire to the authority and people from behind the stand during the parade,""* said Gholam-Reza Shariati, governor of Khuzestan province, according to IRNA.
Khuzestan is a province that borders Iraq and has a large ethnic Arab community, many of them Sunni. It was a major battleground during the Iran-Iraq War that killed half a million soldiers in the '80s.
", DateCreated = new DateTime(2018, 10, 30, 11, 10, 2, 0, DateTimeKind.Unspecified), Header = "Livinng out the Baha'i: A journy to Israel", HomeImageUrl = "https://images.jpost.com/image/upload/f_auto,fl_lossy/t_Article2016_ControlFaceDetect/429990", IsShowMap = false, Location = "תל אביב, ישראל", Summery = "More than a million people visit the gardens every year. Apart from being at the holiest site of his faith..." },
                        new { ArticleId = 8, CategoryId = 5, Content = @"This is an example article with multiple paragraphs, **bolds**, *""quotes""* and others.


example paragraph
--

The statement from attorneys Debra Katz, Lisa Banks and Michael Bromwich came after a call Sunday with staff for the Senate Judiciary Committee. Kavanaugh has denied the allegations and said he wants to testify before the committee.

*""Despite actual threats to her safety and her life, Dr. Ford believes it is important for Senators to hear directly from her about the sexual assault committed against her,""* the statement read.

paragraph with image
--
*""We stand with the Iranian people against the scourge of radical Islamic terrorism and express our sympathy to them at this terrible time,""* she said Saturday.

The parade was part of nationwide celebrations in Iran to mark the 30th anniversary of the end of its eight-year war with Iraq.
Gunmen opened fire on armed forces marching inside a park as well as spectators who had gathered to watch the parade, Iranian armed forces spokesman Brig. Gen. Abolfazl Shekarchi told Mehr, a semi-official Iranian news agency.
All four attackers were killed during clashes with security forces, IRNA reported, citing the deputy governor-general of Khuzestan province, where the attack happened.

![](https://cdn.cnn.com/cnnnext/dam/assets/180922044651-iran-parade-attack-09-22-18-exlarge-169.jpg)
*Injured soldiers lie on the ground after Saturday's attack on a military parade Ahvaz, Iran.*

*""The terrorists disguised as Islamic Revolution Guards Corps and Basij (volunteer) forces opened fire to the authority and people from behind the stand during the parade,""* said Gholam-Reza Shariati, governor of Khuzestan province, according to IRNA.
Khuzestan is a province that borders Iraq and has a large ethnic Arab community, many of them Sunni. It was a major battleground during the Iran-Iraq War that killed half a million soldiers in the '80s.
", DateCreated = new DateTime(2018, 9, 6, 11, 10, 2, 0, DateTimeKind.Unspecified), Header = "Highlights: Texas snaps 4-game skid to No. 17 TCU", HomeImageUrl = "https://img-s-msn-com.akamaized.net/tenant/amp/entityid/AAAuljC.img?h=170&w=300&m=6&q=60&u=t&o=t&l=f&f=jpg&x=585&y=345", IsShowMap = false, Location = "תל אביב, ישראל", Summery = "Finland has produced more Formula One champions per capita than any other country in the world" },
                        new { ArticleId = 9, CategoryId = 6, Content = @"This is an example article with multiple paragraphs, **bolds**, *""quotes""* and others.


example paragraph
--

The statement from attorneys Debra Katz, Lisa Banks and Michael Bromwich came after a call Sunday with staff for the Senate Judiciary Committee. Kavanaugh has denied the allegations and said he wants to testify before the committee.

*""Despite actual threats to her safety and her life, Dr. Ford believes it is important for Senators to hear directly from her about the sexual assault committed against her,""* the statement read.

paragraph with image
--
*""We stand with the Iranian people against the scourge of radical Islamic terrorism and express our sympathy to them at this terrible time,""* she said Saturday.

The parade was part of nationwide celebrations in Iran to mark the 30th anniversary of the end of its eight-year war with Iraq.
Gunmen opened fire on armed forces marching inside a park as well as spectators who had gathered to watch the parade, Iranian armed forces spokesman Brig. Gen. Abolfazl Shekarchi told Mehr, a semi-official Iranian news agency.
All four attackers were killed during clashes with security forces, IRNA reported, citing the deputy governor-general of Khuzestan province, where the attack happened.

![](https://cdn.cnn.com/cnnnext/dam/assets/180922044651-iran-parade-attack-09-22-18-exlarge-169.jpg)
*Injured soldiers lie on the ground after Saturday's attack on a military parade Ahvaz, Iran.*

*""The terrorists disguised as Islamic Revolution Guards Corps and Basij (volunteer) forces opened fire to the authority and people from behind the stand during the parade,""* said Gholam-Reza Shariati, governor of Khuzestan province, according to IRNA.
Khuzestan is a province that borders Iraq and has a large ethnic Arab community, many of them Sunni. It was a major battleground during the Iran-Iraq War that killed half a million soldiers in the '80s.
", DateCreated = new DateTime(2018, 9, 7, 11, 10, 2, 0, DateTimeKind.Unspecified), Header = "Russia is still attacking the US and trying to help Trump", HomeImageUrl = "https://img-s-msn-com.akamaized.net/tenant/amp/entityid/AAAuljC.img?h=170&w=300&m=6&q=60&u=t&o=t&l=f&f=jpg&x=585&y=345", IsShowMap = false, Location = "תל אביב, ישראל", Summery = "Microsoft's revelation of yet another Russian operation assaulting democratic institutions -- including conservative think tanks that disagree with President Trump -- proves that Vladimir Putin is still trying to help Trump, writes Frida Ghitis." },
                        new { ArticleId = 10, CategoryId = 3, Content = @"This is an example article with multiple paragraphs, **bolds**, *""quotes""* and others.


example paragraph
--

The statement from attorneys Debra Katz, Lisa Banks and Michael Bromwich came after a call Sunday with staff for the Senate Judiciary Committee. Kavanaugh has denied the allegations and said he wants to testify before the committee.

*""Despite actual threats to her safety and her life, Dr. Ford believes it is important for Senators to hear directly from her about the sexual assault committed against her,""* the statement read.

paragraph with image
--
*""We stand with the Iranian people against the scourge of radical Islamic terrorism and express our sympathy to them at this terrible time,""* she said Saturday.

The parade was part of nationwide celebrations in Iran to mark the 30th anniversary of the end of its eight-year war with Iraq.
Gunmen opened fire on armed forces marching inside a park as well as spectators who had gathered to watch the parade, Iranian armed forces spokesman Brig. Gen. Abolfazl Shekarchi told Mehr, a semi-official Iranian news agency.
All four attackers were killed during clashes with security forces, IRNA reported, citing the deputy governor-general of Khuzestan province, where the attack happened.

![](https://cdn.cnn.com/cnnnext/dam/assets/180922044651-iran-parade-attack-09-22-18-exlarge-169.jpg)
*Injured soldiers lie on the ground after Saturday's attack on a military parade Ahvaz, Iran.*

*""The terrorists disguised as Islamic Revolution Guards Corps and Basij (volunteer) forces opened fire to the authority and people from behind the stand during the parade,""* said Gholam-Reza Shariati, governor of Khuzestan province, according to IRNA.
Khuzestan is a province that borders Iraq and has a large ethnic Arab community, many of them Sunni. It was a major battleground during the Iran-Iraq War that killed half a million soldiers in the '80s.
", DateCreated = new DateTime(2018, 8, 6, 11, 10, 2, 0, DateTimeKind.Unspecified), Header = "Comcast outbids 21st Century Fox for Sky", HomeImageUrl = "https://i.cdn.turner.com/money/dam/assets/180920115724-comcast-fox-sky-780x439.jpg", IsShowMap = false, Location = "תל אביב, ישראל", Summery = "American cable giant Comcast lodged a winning bid of about $40 billion (£30.6 billion) for Sky following a rare, three round auction managed by UK's Takeover Panel" },
                        new { ArticleId = 11, CategoryId = 3, Content = @"This is an example article with multiple paragraphs, **bolds**, *""quotes""* and others.


example paragraph
--

The statement from attorneys Debra Katz, Lisa Banks and Michael Bromwich came after a call Sunday with staff for the Senate Judiciary Committee. Kavanaugh has denied the allegations and said he wants to testify before the committee.

*""Despite actual threats to her safety and her life, Dr. Ford believes it is important for Senators to hear directly from her about the sexual assault committed against her,""* the statement read.

paragraph with image
--
*""We stand with the Iranian people against the scourge of radical Islamic terrorism and express our sympathy to them at this terrible time,""* she said Saturday.

The parade was part of nationwide celebrations in Iran to mark the 30th anniversary of the end of its eight-year war with Iraq.
Gunmen opened fire on armed forces marching inside a park as well as spectators who had gathered to watch the parade, Iranian armed forces spokesman Brig. Gen. Abolfazl Shekarchi told Mehr, a semi-official Iranian news agency.
All four attackers were killed during clashes with security forces, IRNA reported, citing the deputy governor-general of Khuzestan province, where the attack happened.

![](https://cdn.cnn.com/cnnnext/dam/assets/180922044651-iran-parade-attack-09-22-18-exlarge-169.jpg)
*Injured soldiers lie on the ground after Saturday's attack on a military parade Ahvaz, Iran.*

*""The terrorists disguised as Islamic Revolution Guards Corps and Basij (volunteer) forces opened fire to the authority and people from behind the stand during the parade,""* said Gholam-Reza Shariati, governor of Khuzestan province, according to IRNA.
Khuzestan is a province that borders Iraq and has a large ethnic Arab community, many of them Sunni. It was a major battleground during the Iran-Iraq War that killed half a million soldiers in the '80s.
", DateCreated = new DateTime(2018, 8, 6, 10, 10, 2, 0, DateTimeKind.Unspecified), Header = "BMW vision's for a self-driving electric car", HomeImageUrl = "https://i.cdn.turner.com/money/dam/assets/180913172656-bmw-inext-780x439.jpg", IsShowMap = false, Location = "תל אביב, ישראל", Summery = "BMW has unveiled its vision for a self-driving electric crossover SUV and, if it actually ends up being a lot like the concept." }
                    );
                });

            modelBuilder.Entity("NewsNow.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ColorARGB");

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new { CategoryId = 1, ColorARGB = -15132304, Description = "World wide news", Name = "World" },
                        new { CategoryId = 2, ColorARGB = -7667573, Description = "Debates and conflicts", Name = "Politics" },
                        new { CategoryId = 3, ColorARGB = -16751616, Description = "Trade, commerce and money", Name = "Business" },
                        new { CategoryId = 4, ColorARGB = -7667712, Description = "And its a score!", Name = "Sports" },
                        new { CategoryId = 5, ColorARGB = -2354116, Description = "Music, movies and the starts", Name = "Culture" },
                        new { CategoryId = 6, ColorARGB = -13726889, Description = "I Think...", Name = "Opinions" }
                    );
                });

            modelBuilder.Entity("NewsNow.Models.Comment", b =>
                {
                    b.Property<int>("CommentId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ArticleId");

                    b.Property<string>("Author");

                    b.Property<string>("Content");

                    b.Property<DateTime>("DatePosted");

                    b.Property<int>("Sequence");

                    b.HasKey("CommentId");

                    b.HasIndex("ArticleId");

                    b.ToTable("Comments");

                    b.HasData(
                        new { CommentId = 1, ArticleId = 1, Author = "The one who knows", Content = "Example content for an example comment", DatePosted = new DateTime(2018, 8, 2, 8, 10, 0, 0, DateTimeKind.Unspecified), Sequence = 1 },
                        new { CommentId = 2, ArticleId = 1, Author = "Voldemort", Content = "Multi line comment! I think this is an example comment", DatePosted = new DateTime(2018, 8, 16, 9, 10, 0, 0, DateTimeKind.Unspecified), Sequence = 2 },
                        new { CommentId = 3, ArticleId = 1, Author = "Jimmi", Content = "Example content for an example comment", DatePosted = new DateTime(2018, 9, 2, 8, 0, 15, 0, DateTimeKind.Unspecified), Sequence = 3 }
                    );
                });

            modelBuilder.Entity("NewsNow.Models.ExampleStatisticsModel", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EntersAmount");

                    b.Property<string>("OldestManName");

                    b.HasKey("ID");

                    b.ToTable("ExampleStatistics");
                });

            modelBuilder.Entity("NewsNow.Models.Article", b =>
                {
                    b.HasOne("NewsNow.Models.Category", "Category")
                        .WithMany("Articles")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("NewsNow.Models.Comment", b =>
                {
                    b.HasOne("NewsNow.Models.Article", "Article")
                        .WithMany("Comments")
                        .HasForeignKey("ArticleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
