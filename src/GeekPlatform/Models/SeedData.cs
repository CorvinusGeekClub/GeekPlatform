using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Collections;

namespace GeekPlatform.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider, bool loadSamples)
        {
            using (var context = serviceProvider.GetRequiredService<GeekDatabaseContext>())
            {
                if (loadSamples)
                {
                    context.Database.EnsureDeleted();
                    context.Database.Migrate();
                    AddProfiles(context);
                    AddCourses(context);
                    AddCourseNews(context);
                    AddCourseThematics(context);
                    AddThematicsAttachments(context);
                    AddCourseEnrollments(context);
                    AddHomeworkUploads(context);
                    AddCompetencies(context);
                    AddMemberCompetencies(context);
                } else
                {
                    context.Database.Migrate();
                }
            }
        }

        private static void AddProfiles(GeekDatabaseContext context)
        {
            context.Profile.AddRange(
            new Profile()
            {
                Name = "Evelyn Stevens",
                TeamMember = "Oktatási team",
                MembershipStart = new DateTime(2013, 1, 19),
                UniStartYear = 2013,
                Major = "Gazdaságinformatikus",
                Workplace = "Abata",
                Email = "estevens0@globo.com",
                Phone = "+36707116870",
                Skype = "Champ-e0",
                Slack = "estevens0",
                Address = "91 Longview Point",
                Birthday = new DateTime(1986, 8, 10),
                PicFileName = "estevens0-6137.jpg",
                IsAdmin = true,
                IsActive = true
            },
            new Profile()
            {
                Name = "Marilyn Sanchez",
                TeamMember = "HR team",
                MembershipStart = new DateTime(2013, 5, 1),
                UniStartYear = 2016,
                Major = "Gazdaságinformatikus",
                Workplace = "Feedfish",
                Email = "msanchez1@people.com.cn",
                Phone = "+36200561373",
                Skype = "m.andrew.sanchez1",
                Slack = "msanchez1",
                Address = "532 Packers Park",
                Birthday = new DateTime(1993, 12, 22),
                PicFileName = "msanchez1-4255.jpg",
                IsAdmin = false,
                IsActive = false
            },
            new Profile()
            {
                Name = "Howard Freeman",
                TeamMember = "Marketing team",
                MembershipStart = new DateTime(2012, 11, 27),
                UniStartYear = 2013,
                Major = "Gazdaságinformatikus",
                Workplace = null,
                Email = "hfreeman2@sun.com",
                Phone = "+36201273286",
                Skype = "hfreeman2",
                Slack = "hfreeman2",
                Address = "17797 Macpherson Lane",
                Birthday = new DateTime(1998, 10, 6),
                PicFileName = "hfreeman2-132.jpg",
                IsAdmin = false,
                IsActive = true
            },
            new Profile()
            {
                Name = "Ruth Hudson",
                TeamMember = "Pénzügy team",
                MembershipStart = new DateTime(2012, 9, 22),
                UniStartYear = 2016,
                Major = "Gazdaságinformatikus",
                Workplace = null,
                Email = "rhudson3@biglobe.ne.jp",
                Phone = "+36307088635",
                Skype = "rhudson3",
                Slack = "rhudson3",
                Address = "94287 Vera Crossing",
                Birthday = new DateTime(1988, 9, 9),
                PicFileName = "rhudson3-3461.jpg",
                IsAdmin = false,
                IsActive = true
            },
            new Profile()
            {
                Name = "Jane Watson",
                TeamMember = "Marketing team",
                MembershipStart = new DateTime(2013, 9, 12),
                UniStartYear = 2014,
                Major = "Gazdaságinformatikus",
                Workplace = "Brightdog",
                Email = "jwatson4@bbc.co.uk",
                Phone = "+36308026430",
                Skype = "jwatson4",
                Slack = "jwatson4",
                Address = "83918 Thompson Junction",
                Birthday = new DateTime(1988, 4, 7),
                PicFileName = "jwatson4-1170.png",
                IsAdmin = false,
                IsActive = true
            },
            new Profile()
            {
                Name = "Bonnie Wallace",
                TeamMember = "Operatív team",
                MembershipStart = new DateTime(2017, 3, 3),
                UniStartYear = 2011,
                Major = "Gazdaságinformatikus",
                Workplace = null,
                Email = "bwallace5@kickstarter.com",
                Phone = "+36207868020",
                Skype = "bwallace5",
                Slack = "bwallace5",
                Address = "9 Old Shore Trail",
                Birthday = new DateTime(1993, 6, 24),
                PicFileName = "bwallace5-2053.png",
                IsAdmin = false,
                IsActive = true
            },
            new Profile()
            {
                Name = "Kathleen Howell",
                TeamMember = "Marketing team",
                MembershipStart = new DateTime(2015, 11, 1),
                UniStartYear = 2011,
                Major = "Alkalmazott közgazdaságtan",
                Workplace = null,
                Email = "khowell6@ehow.com",
                Phone = "+36304573366",
                Skype = "khowell6",
                Slack = "khowell6",
                Address = "04 Bunker Hill Road",
                Birthday = new DateTime(1999, 9, 15),
                PicFileName = "khowell6-611.png",
                IsAdmin = false,
                IsActive = true
            },
            new Profile()
            {
                Name = "Anne Day",
                TeamMember = "Operatív team",
                MembershipStart = new DateTime(2015, 12, 10),
                UniStartYear = 2010,
                Major = "Gazdaságinformatikus",
                Workplace = "Digitube",
                Email = "aday7@comsenz.com",
                Phone = "+36201550561",
                Skype = "aday7",
                Slack = "aday7",
                Address = "342 Prairie Rose Way",
                Birthday = new DateTime(1989, 9, 2),
                PicFileName = "aday7-5210.jpg",
                IsAdmin = false,
                IsActive = false
            },
            new Profile()
            {
                Name = "Andrew Nguyen",
                TeamMember = "Operatív team",
                MembershipStart = new DateTime(2012, 6, 6),
                UniStartYear = 2013,
                Major = "Gazdaságinformatikus",
                Workplace = null,
                Email = "anguyen8@themeforest.net",
                Phone = "+36708737188",
                Skype = "anguyen8",
                Slack = "anguyen8",
                Address = "9 Jenifer Lane",
                Birthday = new DateTime(1992, 10, 5),
                PicFileName = "anguyen8-5583.jpg",
                IsAdmin = false,
                IsActive = true
            },
            new Profile()
            {
                Name = "Larry Sanchez",
                TeamMember = "HR team",
                MembershipStart = new DateTime(2016, 5, 7),
                UniStartYear = 2011,
                Major = "Gazdaságinformatikus",
                Workplace = "Skiptube",
                Email = "lsanchez9@mail.ru",
                Phone = "+36702143611",
                Skype = "lsanchez9",
                Slack = "lsanchez9",
                Address = "9058 Fieldstone Hill",
                Birthday = new DateTime(1992, 10, 4),
                PicFileName = "lsanchez9-7396.png",
                IsAdmin = false,
                IsActive = false
            },
            new Profile()
            {
                Name = "Sara Green",
                TeamMember = "Pénzügy team",
                MembershipStart = new DateTime(2013, 8, 3),
                UniStartYear = 2013,
                Major = "Gazdaságinformatikus",
                Workplace = null,
                Email = "sgreena@google.pl",
                Phone = "+36702320025",
                Skype = "sgreena",
                Slack = "sgreena",
                Address = "3 Thierer Lane",
                Birthday = new DateTime(1987, 9, 9),
                PicFileName = "sgreena-6249.jpg",
                IsAdmin = false,
                IsActive = true
            },
            new Profile()
            {
                Name = "Chris Bennett",
                TeamMember = "Oktatási team",
                MembershipStart = new DateTime(2014, 8, 1),
                UniStartYear = 2012,
                Major = "Gazdaságinformatikus",
                Workplace = "Mita",
                Email = "cbennettb@alexa.com",
                Phone = "+36208348623",
                Skype = "cbennettb",
                Slack = "cbennettb",
                Address = "8145 3rd Drive",
                Birthday = new DateTime(1986, 4, 22),
                PicFileName = "cbennettb-9426.jpg",
                IsAdmin = true,
                IsActive = true
            },
            new Profile()
            {
                Name = "Thomas Scott",
                TeamMember = "Pénzügy team",
                MembershipStart = new DateTime(2016, 6, 19),
                UniStartYear = 2014,
                Major = "Gazdálkodási és menedzsment",
                Workplace = null,
                Email = "tscottc@tumblr.com",
                Phone = "+36200162676",
                Skype = "tscottc",
                Slack = "tscottc",
                Address = "5103 Dahle Junction",
                Birthday = new DateTime(1988, 12, 21),
                PicFileName = "tscottc-5838.jpg",
                IsAdmin = false,
                IsActive = true
            },
            new Profile()
            {
                Name = "Peter Montgomery",
                TeamMember = "HR team",
                MembershipStart = new DateTime(2013, 11, 3),
                UniStartYear = 2015,
                Major = "Gazdálkodási és menedzsment",
                Workplace = null,
                Email = "pmontgomeryd@illinois.edu",
                Phone = "+36200474224",
                Skype = "pmontgomeryd",
                Slack = "pmontgomeryd",
                Address = "5025 Bay Terrace",
                Birthday = new DateTime(1998, 5, 12),
                PicFileName = "pmontgomeryd-4916.png",
                IsAdmin = false,
                IsActive = true
            },
            new Profile()
            {
                Name = "Nicole Clark",
                TeamMember = "HR team",
                MembershipStart = new DateTime(2013, 4, 20),
                UniStartYear = 2013,
                Major = "Gazdaságinformatikus",
                Workplace = null,
                Email = "nclarke@addthis.com",
                Phone = "+36304671167",
                Skype = "nclarke",
                Slack = "nclarke",
                Address = "991 Bowman Alley",
                Birthday = new DateTime(1985, 3, 14),
                PicFileName = "nclarke-1580.jpg",
                IsAdmin = false,
                IsActive = true
            },
            new Profile()
            {
                Name = "Ryan Stone",
                TeamMember = "Pénzügy team",
                MembershipStart = new DateTime(2013, 1, 15),
                UniStartYear = 2013,
                Major = "Gazdaságinformatikus",
                Workplace = null,
                Email = "rstonef@instagram.com",
                Phone = "+36708070833",
                Skype = "rstonef",
                Slack = "rstonef",
                Address = "1499 Clarendon Junction",
                Birthday = new DateTime(1998, 8, 28),
                PicFileName = "rstonef-7427.png",
                IsAdmin = false,
                IsActive = true
            },
            new Profile()
            {
                Name = "Cheryl Wallace",
                TeamMember = "Operatív team",
                MembershipStart = new DateTime(2014, 1, 27),
                UniStartYear = 2012,
                Major = "Gazdaságinformatikus",
                Workplace = "Bubblebox",
                Email = "cwallaceg@amazon.co.uk",
                Phone = "+36204086535",
                Skype = "cwallaceg",
                Slack = "cwallaceg",
                Address = "3 8th Circle",
                Birthday = new DateTime(1990, 6, 3),
                PicFileName = "cwallaceg-7594.png",
                IsAdmin = false,
                IsActive = true
            },
            new Profile()
            {
                Name = "Gerald Cole",
                TeamMember = "Oktatási team",
                MembershipStart = new DateTime(2012, 6, 29),
                UniStartYear = 2014,
                Major = "Gazdaságinformatikus",
                Workplace = null,
                Email = "gcoleh@ameblo.jp",
                Phone = "+36304166561",
                Skype = "gcoleh",
                Slack = "gcoleh",
                Address = "4618 Goodland Circle",
                Birthday = new DateTime(1995, 9, 4),
                PicFileName = "gcoleh-7970.jpg",
                IsAdmin = false,
                IsActive = false
            },
            new Profile()
            {
                Name = "Alan Bell",
                TeamMember = "Operatív team",
                MembershipStart = new DateTime(2014, 4, 1),
                UniStartYear = 2010,
                Major = "Gazdaságinformatikus",
                Workplace = null,
                Email = "abelli@hubpages.com",
                Phone = "+36700872846",
                Skype = "abelli",
                Slack = "abelli",
                Address = "720 Quincy Crossing",
                Birthday = new DateTime(1986, 12, 28),
                PicFileName = "abelli-6228.jpg",
                IsAdmin = false,
                IsActive = false
            },
            new Profile()
            {
                Name = "Roger Romero",
                TeamMember = "Operatív team",
                MembershipStart = new DateTime(2015, 8, 23),
                UniStartYear = 2010,
                Major = "Gazdaságinformatikus",
                Workplace = null,
                Email = "rromeroj@dailymail.co.uk",
                Phone = "+36307665784",
                Skype = "rromeroj",
                Slack = "rromeroj",
                Address = "4 Lunder Plaza",
                Birthday = new DateTime(1999, 10, 21),
                PicFileName = "rromeroj-7640.png",
                IsAdmin = false,
                IsActive = true
            },
            new Profile()
            {
                Name = "Jack Grant",
                TeamMember = "Marketing team",
                MembershipStart = new DateTime(2013, 5, 24),
                UniStartYear = 2014,
                Major = "Gazdaságinformatikus",
                Workplace = null,
                Email = "jgrantk@sfgate.com",
                Phone = "+36703018417",
                Skype = "jgrantk",
                Slack = "jgrantk",
                Address = "6 Service Road",
                Birthday = new DateTime(1987, 6, 17),
                PicFileName = "jgrantk-2463.png",
                IsAdmin = true,
                IsActive = true
            },
            new Profile()
            {
                Name = "Philip Romero",
                TeamMember = "HR team",
                MembershipStart = new DateTime(2016, 9, 16),
                UniStartYear = 2016,
                Major = "Gazdaságinformatikus",
                Workplace = null,
                Email = "promerol@tripod.com",
                Phone = "+36300787270",
                Skype = "promerol",
                Slack = "promerol",
                Address = "56198 Comanche Lane",
                Birthday = new DateTime(1999, 2, 20),
                PicFileName = "promerol-3883.jpg",
                IsAdmin = false,
                IsActive = true
            },
            new Profile()
            {
                Name = "Tina Carr",
                TeamMember = "Pénzügy team",
                MembershipStart = new DateTime(2013, 3, 25),
                UniStartYear = 2013,
                Major = "Gazdaságinformatikus",
                Workplace = "Oyope",
                Email = "tcarrm@lulu.com",
                Phone = "+36700803121",
                Skype = "tcarrm",
                Slack = "tcarrm",
                Address = "97 Evergreen Pass",
                Birthday = new DateTime(1989, 5, 16),
                PicFileName = "tcarrm-3662.jpg",
                IsAdmin = true,
                IsActive = true
            },
            new Profile()
            {
                Name = "Catherine Allen",
                TeamMember = "Operatív team",
                MembershipStart = new DateTime(2012, 11, 18),
                UniStartYear = 2013,
                Major = "Gazdaságinformatikus",
                Workplace = "Buzzdog",
                Email = "callenn@slate.com",
                Phone = "+36307141300",
                Skype = "callenn",
                Slack = "XxXcallenn",
                Address = "0642 Main Terrace",
                Birthday = new DateTime(1995, 4, 24),
                PicFileName = "callenn-1429.jpg",
                IsAdmin = false,
                IsActive = true
            },
            new Profile()
            {
                Name = "Lois Gomez",
                TeamMember = "HR team",
                MembershipStart = new DateTime(2013, 2, 2),
                UniStartYear = 2014,
                Major = "Gazdaságinformatikus",
                Workplace = "Innojam",
                Email = "lgomezo@sbwire.com",
                Phone = "+36300870682",
                Skype = "ssmezo",
                Slack = "lgomezo",
                Address = "2591 Park Meadow Place",
                Birthday = new DateTime(1988, 1, 30),
                PicFileName = "lgomezo-4337.png",
                IsAdmin = false,
                IsActive = true
            },
            new Profile()
            {
                Name = "Victor Diaz",
                TeamMember = "Pénzügy team",
                MembershipStart = new DateTime(2014, 9, 2),
                UniStartYear = 2011,
                Major = "Gazdaságinformatikus",
                Workplace = "Meeveo",
                Email = "vdiazp@yahoo.co.jp",
                Phone = "+36705622460",
                Skype = "newermzp",
                Slack = "vdiazp",
                Address = "0587 Rowland Trail",
                Birthday = new DateTime(1998, 1, 25),
                PicFileName = "vdiazp-3914.png",
                IsAdmin = false,
                IsActive = true
            },
            new Profile()
            {
                Name = "Christina Green",
                TeamMember = "Oktatási team",
                MembershipStart = new DateTime(2015, 7, 14),
                UniStartYear = 2013,
                Major = "Nemzetközi kapcsolatok",
                Workplace = "Feedbug",
                Email = "cgreenq@who.int",
                Phone = "+36204056880",
                Skype = "cgreenq",
                Slack = "cgreenq",
                Address = "4 Dwight Alley",
                Birthday = new DateTime(1986, 9, 28),
                PicFileName = "cgreenq-2789.jpg",
                IsAdmin = false,
                IsActive = true
            },
            new Profile()
            {
                Name = "Gloria Olson",
                TeamMember = "Oktatási team",
                MembershipStart = new DateTime(2016, 6, 20),
                UniStartYear = 2013,
                Major = "Filozófia",
                Workplace = "Oyonder",
                Email = "golsonr@quantcast.com",
                Phone = "+36701344834",
                Skype = "golsonr",
                Slack = "golsonr",
                Address = "77 Lien Hill",
                Birthday = new DateTime(1991, 7, 1),
                PicFileName = "golsonr-1240.png",
                IsAdmin = false,
                IsActive = true
            },
            new Profile()
            {
                Name = "Willie Simmons",
                TeamMember = "Pénzügy team",
                MembershipStart = new DateTime(2015, 6, 5),
                UniStartYear = 2011,
                Major = "Gazdaságinformatikus",
                Workplace = "Quamba",
                Email = "wsimmonss@nsw.gov.au",
                Phone = "+36704164755",
                Skype = "wsimmonss",
                Slack = "wsimmonss",
                Address = "42053 Reindahl Court",
                Birthday = new DateTime(1991, 7, 28),
                PicFileName = "wsimmonss-5852.png",
                IsAdmin = false,
                IsActive = true
            },
            new Profile()
            {
                Name = "Kelly Meyer",
                TeamMember = "Marketing team",
                MembershipStart = new DateTime(2012, 6, 25),
                UniStartYear = 2013,
                Major = "Gazdaságinformatikus",
                Workplace = "Cogidoo",
                Email = "kmeyert@multiply.com",
                Phone = "+36308608818",
                Skype = "kmeyert",
                Slack = "kmeyert",
                Address = "61 Hooker Lane",
                Birthday = new DateTime(1994, 4, 12),
                PicFileName = "kmeyert-2516.jpg",
                IsAdmin = false,
                IsActive = false
            },
            new Profile()
            {
                Name = "Kevin Spencer",
                TeamMember = "HR team",
                MembershipStart = new DateTime(2013, 3, 28),
                UniStartYear = 2013,
                Major = "Gazdaságinformatikus",
                Workplace = "Linktype",
                Email = "kspenceru@guardian.co.uk",
                Phone = "+36207643658",
                Skype = "kspenceru",
                Slack = "kspenceru",
                Address = "3 Dwight Crossing",
                Birthday = new DateTime(1999, 3, 4),
                PicFileName = "kspenceru-6800.png",
                IsAdmin = false,
                IsActive = true
            },
            new Profile()
            {
                Name = "Thomas Ross",
                TeamMember = "Pénzügy team",
                MembershipStart = new DateTime(2013, 10, 24),
                UniStartYear = 2014,
                Major = "Gazdaságinformatikus",
                Workplace = "Babblestorm",
                Email = "trossv@tripod.com",
                Phone = "+36306304688",
                Skype = "trossv",
                Slack = "trossv",
                Address = "97087 Sheridan Crossing",
                Birthday = new DateTime(1985, 3, 26),
                PicFileName = "trossv-5978.png",
                IsAdmin = false,
                IsActive = true
            },
            new Profile()
            {
                Name = "Rachel Harris",
                TeamMember = "Operatív team",
                MembershipStart = new DateTime(2015, 11, 18),
                UniStartYear = 2013,
                Major = "Alkalmazott közgazdaságtan",
                Workplace = null,
                Email = "rharrisw@bravesites.com",
                Phone = "+36306083401",
                Skype = "rharrisw",
                Slack = "rharrisw",
                Address = "758 Eagan Lane",
                Birthday = new DateTime(1999, 11, 22),
                PicFileName = "rharrisw-5532.jpg",
                IsAdmin = true,
                IsActive = true
            },
            new Profile()
            {
                Name = "Donna Medina",
                TeamMember = "Oktatási team",
                MembershipStart = new DateTime(2017, 3, 4),
                UniStartYear = 2011,
                Major = "Alkalmazott közgazdaságtan",
                Workplace = "Eadel",
                Email = "dmedinax@telegraph.co.uk",
                Phone = "+36704254075",
                Skype = "dmedinax",
                Slack = "dmedinax",
                Address = "86 Jay Crossing",
                Birthday = new DateTime(1997, 8, 17),
                PicFileName = "dmedinax-923.png",
                IsAdmin = false,
                IsActive = false
            },
            new Profile()
            {
                Name = "Martin Lee",
                TeamMember = "HR team",
                MembershipStart = new DateTime(2012, 5, 20),
                UniStartYear = 2010,
                Major = "Gazdaságinformatikus",
                Workplace = null,
                Email = "mleey@skype.com",
                Phone = "+36204386567",
                Skype = "mleey",
                Slack = "mleey",
                Address = "5274 Northview Park",
                Birthday = new DateTime(1997, 9, 21),
                PicFileName = "mleey-4057.jpg",
                IsAdmin = true,
                IsActive = false
            },
            new Profile()
            {
                Name = "Katherine Bishop",
                TeamMember = "Marketing team",
                MembershipStart = new DateTime(2015, 11, 14),
                UniStartYear = 2011,
                Major = "Filozófia",
                Workplace = "Photolist",
                Email = "kbishopz@zdnet.com",
                Phone = "+36202266560",
                Skype = "kbishopz",
                Slack = "kbishopz",
                Address = "023 Cody Hill",
                Birthday = new DateTime(1986, 9, 14),
                PicFileName = "kbishopz-9088.jpg",
                IsAdmin = false,
                IsActive = false
            },
            new Profile()
            {
                Name = "Louis Morrison",
                TeamMember = "HR team",
                MembershipStart = new DateTime(2014, 12, 23),
                UniStartYear = 2016,
                Major = "Gazdaságinformatikus",
                Workplace = null,
                Email = "lmorrison10@mozilla.org",
                Phone = "+36205247337",
                Skype = "lmorrison10",
                Slack = "lmorrison10",
                Address = "84 Main Alley",
                Birthday = new DateTime(1997, 12, 23),
                PicFileName = "lmorrison10-8138.png",
                IsAdmin = true,
                IsActive = false
            },
            new Profile()
            {
                Name = "Dennis Morales",
                TeamMember = "Oktatási team",
                MembershipStart = new DateTime(2012, 6, 1),
                UniStartYear = 2011,
                Major = "Gazdaságinformatikus",
                Workplace = "Photobug",
                Email = "dmorales11@bing.com",
                Phone = "+36205555366",
                Skype = "dmorales11",
                Slack = "dmorales11",
                Address = "590 Schmedeman Circle",
                Birthday = new DateTime(1999, 7, 20),
                PicFileName = "dmorales11-9103.png",
                IsAdmin = false,
                IsActive = true
            },
            new Profile()
            {
                Name = "Thomas Dunn",
                TeamMember = "Operatív team",
                MembershipStart = new DateTime(2013, 3, 28),
                UniStartYear = 2013,
                Major = "Gazdálkodási és menedzsment",
                Workplace = "Twinte",
                Email = "tdunnu@go.com",
                Phone = "+36705516046",
                Skype = "tdunnu",
                Slack = "tdunnu",
                Address = "7729 7th Drive",
                Birthday = new DateTime(1994, 12, 22),
                PicFileName = "tdunnu-8658.jpg",
                IsAdmin = false,
                IsActive = true
            },
            new Profile()
            {
                Name = "Kimberly Wood",
                TeamMember = "HR team",
                MembershipStart = new DateTime(2013, 10, 24),
                UniStartYear = 2014,
                Major = "Gazdaságinformatikus",
                Workplace = "Mita",
                Email = "kwoodv@businessinsider.com",
                Phone = "+36207360624",
                Skype = "kwoodv",
                Slack = "kwoodv",
                Address = "049 Buena Vista Plaza",
                Birthday = new DateTime(1993, 12, 6),
                PicFileName = "kwoodv-4739.jpg",
                IsAdmin = true,
                IsActive = false
            },
            new Profile()
            {
                Name = "Amy Burke",
                TeamMember = "Operatív team",
                MembershipStart = new DateTime(2015, 11, 18),
                UniStartYear = 2013,
                Major = "Nemzetközi kapcsolatok",
                Workplace = "Shuffletag",
                Email = "aburkew@oakley.com",
                Phone = "+36300545126",
                Skype = "aburkew",
                Slack = "aburkewburrito",
                Address = "0 Burrows Parkway",
                Birthday = new DateTime(1999, 12, 31),
                PicFileName = "aburkew-168.png",
                IsAdmin = false,
                IsActive = true
            },
            new Profile()
            {
                Name = "Paul Kelly",
                TeamMember = "HR team",
                MembershipStart = new DateTime(2017, 3, 4),
                UniStartYear = 2011,
                Major = "Gazdaságinformatikus",
                Workplace = null,
                Email = "pkellyx@hatena.ne.jp",
                Phone = "+36308028803",
                Skype = "pkellyx",
                Slack = "pkellyx",
                Address = "44 Knutson Road",
                Birthday = new DateTime(1990, 7, 5),
                PicFileName = "pkellyx-9329.jpg",
                IsAdmin = false,
                IsActive = true
            },
            new Profile()
            {
                Name = "Rose Freeman",
                TeamMember = "Operatív team",
                MembershipStart = new DateTime(2012, 5, 20),
                UniStartYear = 2010,
                Major = "Nemzetközi kapcsolatok",
                Workplace = "Tavu",
                Email = "rfreemany@eepurl.com",
                Phone = "+36203880621",
                Skype = "rfreemany",
                Slack = "rfreemany",
                Address = "90 Declaration Junction",
                Birthday = new DateTime(1992, 7, 23),
                PicFileName = "rfreemany-2519.jpg",
                IsAdmin = false,
                IsActive = true
            },
            new Profile()
            {
                Name = "Timothy Bell",
                TeamMember = "HR team",
                MembershipStart = new DateTime(2015, 11, 14),
                UniStartYear = 2011,
                Major = "Gazdaságinformatikus",
                Workplace = "Jetwire",
                Email = "tbellz@facebook.com",
                Phone = "+36302487878",
                Skype = "tbellz",
                Slack = "tbellz",
                Address = "36 Gerald Lane",
                Birthday = new DateTime(1992, 2, 5),
                PicFileName = "tbellz-5439.png",
                IsAdmin = false,
                IsActive = true
            },
            new Profile()
            {
                Name = "Karen Ellis",
                TeamMember = "Operatív team",
                MembershipStart = new DateTime(2014, 12, 23),
                UniStartYear = 2016,
                Major = "Filozófia",
                Workplace = "IBM",
                Email = "kellis10@alibaba.com",
                Phone = "+36707532452",
                Skype = "kellisTherEAL",
                Slack = "kellis10",
                Address = "047 Golf Course Crossing",
                Birthday = new DateTime(1999, 8, 16),
                PicFileName = "kellis10-4552.jpg",
                IsAdmin = false,
                IsActive = true
            }
        );
            context.SaveChanges();
        }
        private static void AddCourses(GeekDatabaseContext context)
        {
            context.Course.AddRange(
            new Course()
            {
                CourseName = "Webfejl 1",
                DescriptionShort = "Webfejlesztés alapok",
                DescriptionLong = "Webfejlesztés alapok: HTML, CSS",
                IconFileName = "webf-1.png",
                IsWorkshop = false,
                IsActive = true,
                IsRunning = true,
                SignUpDeadline = DateTime.Today.AddDays(-3)
            },

            new Course()
            {
                CourseName = "Python workshop",
                DescriptionShort = "Python workshop.py3",
                DescriptionLong = "Python workshop py3-al",
                IconFileName = "pyc-4.jpg",
                IsWorkshop = true,
                IsActive = true,
                IsRunning = true,
                SignUpDeadline = DateTime.Today.AddDays(2)
            },

            new Course()
            {
                CourseName = "Grafika 1",
                DescriptionShort = "Grafika 1 Adobe CC-al",
                DescriptionLong = "Grafika 1 Adobe CC-al a cloudon",
                IconFileName = "ashop-8.png",
                IsWorkshop = false,
                IsActive = true,
                IsRunning = false,
                SignUpDeadline = DateTime.Today.AddDays(-20)
            },

            new Course()
            {
                CourseName = "UX design",
                DescriptionShort = "UX design gyakorlatok",
                DescriptionLong = "UX design gyakorlatok: web 2.0",
                IconFileName = "uxs-a73e.png",
                IsWorkshop = false,
                IsActive = true,
                IsRunning = true,
                SignUpDeadline = DateTime.Today.AddDays(-3)
            },

            new Course()
            {
                CourseName = "BigData 1",
                DescriptionShort = "BigData 1",
                DescriptionLong = "BigData 1 a felhőben",
                IconFileName = "cloudy.png",
                IsWorkshop = false,
                IsActive = false,
                IsRunning = false,
                SignUpDeadline = DateTime.Today.AddDays(-20)
            });

            context.SaveChanges();

        }

        private static void AddCourseNews(GeekDatabaseContext context)
        {
            Course web1 = context.Course.First(c => c.CourseName == "Webfejl 1");
            web1.CourseNews.Add(
                new CourseNews()
                {
                    Title = "Bevezetes",
                    Content = "Sziasztok itt a webfejl 1 kurzuson!",
                    PostTime = DateTime.Now.AddDays(-1)
                }
            );
            web1.CourseNews.Add(
                new CourseNews()
                {
                    Title = "Visual Studio Beallitasok",
                    Content = "Az ASP.NET Core rejtelmeit a prpjekten talaljatok.",
                    PostTime = DateTime.Now
                });
            context.SaveChanges();
        }
        private static void AddCourseThematics(GeekDatabaseContext context)
        {
            Course web1 = context.Course.First(c => c.CourseName == "Webfejl 1");
            int id = web1.CourseId;
            context.CourseThematics.AddRange(
                new CourseThematics()
                {
                    CourseId = id,
                    WeekNumber = 1,
                    ActualDate = DateTime.Now.AddDays(2),
                    Title = "Kezdeti alkalom",
                    Description = "Ismerkedes a HTML-el"
                },
                new CourseThematics()
                {
                    CourseId = id,
                    WeekNumber = 2,
                    ActualDate = DateTime.Now.AddDays(2),
                    Title = "CSS alapok",
                    Description = "CSS bevezeto"
                }
                );

            context.SaveChanges();
        }


        private static void AddThematicsAttachments(GeekDatabaseContext context)
        {
            CourseThematics ct = context.CourseThematics.First(c => c.Course.CourseName == "Webfejl 1");
            ct.ThematicsAttachment.Add(new ThematicsAttachment() { Description = "HTML hazi", AttachmentFileName = "htmls.zip", IsActive = true, IsHomework = true });
            context.SaveChanges();
        }

        private static void AddCourseEnrollments(GeekDatabaseContext context)
        {
            String[,] teachers = new String[,]
            {
                { "Howard Freeman", "Webfejl 1" },
                { "Evelyn Stevens", "Webfejl 1" },
                { "Ruth Hudson", "BigData 1" },
                { "Evelyn Stevens", "UX design" },
                { "Evelyn Stevens", "Grafika 1" },
                { "Cheryl Wallace", "Grafika 1" },
                { "Howard Freeman", "Python workshop" },
                { "Chris Bennett", "Python workshop" }
            };

            String[,] students = new String[,]
            {
                { "Thomas Scott", "Webfejl 1" },
                { "Chris Bennett", "Webfejl 1" },
                { "Howard Freeman", "Grafika 1" },
                { "Ryan Stone", "Webfejl 1" },
                { "Jack Grant", "Webfejl 1" },
                { "Cheryl Wallace", "BigData 1" },
                { "Alan Bell", "UX design" },
                { "Thomas Scott", "Grafika 1" },
                { "Catherine Allen", "Grafika 1" },
                { "Roger Romero", "Python workshop" },
                { "Jack Grant", "Python workshop" },
                { "Tina Carr", "Python workshop" },
                { "Ryan Stone", "Python workshop" }
            };

            for (int i = 0; i < teachers.GetLength(0); i++)
            {
                int profile_id = context.Profile.First(e => e.Name == teachers[i, 0]).ProfileId;
                int course_id = context.Course.First(e => e.CourseName == teachers[i, 1]).CourseId;
                context.CourseEnrollment.Add(new CourseEnrollment() { CourseId = course_id, ProfileId = profile_id, IsInstructor = true, IsFinished = false });
            }

            for (int i = 0; i < students.GetLength(0); i++)
            {
                int profile_id = context.Profile.First(e => e.Name == students[i, 0]).ProfileId;
                int course_id = context.Course.First(e => e.CourseName == students[i, 1]).CourseId;
                context.CourseEnrollment.Add(new CourseEnrollment() { CourseId = course_id, ProfileId = profile_id, IsInstructor = false, IsFinished = false });
            }

            context.SaveChanges();
        }

        private static void AddHomeworkUploads(GeekDatabaseContext context)
        {
            int course_id = context.Course.First(c => c.CourseName == "Webfejl 1").CourseId;
            context.HomeworkUpload.AddRange(
                new HomeworkUpload() { CourseId = course_id, WeekNumber = 1, UploadFileName = "hazi1.zip", Comment = "Hazi Feladat 1", UploadDateTime = DateTime.Now.AddDays(-4), ProfileId = context.Profile.First(p => p.Name == "Jack Grant").ProfileId, IsActive = true },
                new HomeworkUpload() { CourseId = course_id, WeekNumber = 1, UploadFileName = "web.zip", Comment = "1. Hazi Feladat", UploadDateTime = DateTime.Now.AddDays(-3), ProfileId = context.Profile.First(p => p.Name == "Thomas Scott").ProfileId, IsActive = false },
                new HomeworkUpload() { CourseId = course_id, WeekNumber = 1, UploadFileName = "uj-web.zip", Comment = "Javitott 1. Hazi Feladat", UploadDateTime = DateTime.Now.AddDays(-2), ProfileId = context.Profile.First(p => p.Name == "Thomas Scott").ProfileId, IsActive = true }
            );
            context.SaveChanges();
        }

        private static void AddCompetencies(GeekDatabaseContext context)
        {
            String[] skills = new[] { "Grafika", "UX design", "Webfejlesztes" };
            foreach (String skill in skills)
            {
                context.Competency.Add(new Competency { CompetencyName = skill });
            }

            context.SaveChanges();
        }

        private static void AddMemberCompetencies(GeekDatabaseContext context)
        {
            HashSet<List<String>> maps = new HashSet<List<string>>() {
                new List<String>() { "Howard Freeman", "Webfejlesztes", "8" },
                new List<String>() { "Howard Freeman", "UX design", "4" },
                new List<String>() { "Howard Freeman", "Grafika", "7" },
                new List<String>() { "Evelyn Stevens", "UX design", "9" },
                new List<String>() { "Evelyn Stevens", "Webfejlesztes", "0" },
                new List<String>() { "Cheryl Wallace", "Grafika", "8" },
                new List<String>() { "Cheryl Wallace", "Webfejlesztes", "4" },
                new List<String>() { "Roger Romero", "Webfejlesztes", "5" },
                new List<String>() { "Jack Grant", "Webfejlesztes", "6" },
                new List<String>() { "Jack Grant", "UX design", "2" },
                new List<String>() { "Tina Carr", "Grafika", "5" }
            };
            foreach (var map in maps)
            {
                int profile_id = context.Profile.First(e => e.Name == map[0]).ProfileId;
                int comp_id = context.Competency.First(e => e.CompetencyName == map[1]).CompetencyId;
                context.MemberCompetency.Add(new MemberCompetency() { ProfileId = profile_id, CompetencyId = comp_id, CompetencyLvl = int.Parse(map[2]), CompetencyComment = $"{map[1]} skill" });
            }
            context.SaveChanges();
        }

    }
}
