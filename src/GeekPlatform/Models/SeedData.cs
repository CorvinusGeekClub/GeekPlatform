﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Identity;
using System.Collections;

namespace GeekPlatform.Models
{
    public static class SeedData
    {
        public static async Task Initialize(IServiceProvider serviceProvider, bool loadSamples = false)
        {
            using (var context = serviceProvider.GetRequiredService<GeekDatabaseContext>())
            {
                if (loadSamples)
                {
                    context.Database.EnsureDeleted();
                    context.Database.Migrate();

                    await AddProfiles(context, serviceProvider.GetRequiredService<UserManager<Profile>>());
                    AddCourses(context);
                    AddCourseNews(context);
                    AddCourseThematics(context);
                    AddThematicsAttachments(context);
                    AddCourseEnrollments(context);
                    AddHomeworkUploads(context);
                    AddCompetencies(context);
                    AddMemberCompetencies(context);
                    AddGalleries(context);
                }
                else
                {
                    context.Database.Migrate();
                }
            }
        }

        private static async Task AddProfiles(GeekDatabaseContext context, UserManager<Profile> userManager)
        {
            const string PWD = "12345678";

            // delete all users
            foreach (var p in await userManager.Users.ToListAsync())
            {
                await userManager.DeleteAsync(p);
            }

            var profiles = new[] {
                new Profile()
                {
                    Name = "Evelyn Stevenson",
                    TeamMember = "Oktatási team",
                    MembershipStart = new DateTime(2013, 1, 19),
                    UniStartYear = 2013,
                    Major = "Gazdaságinformatikus",
                    Workplace = "Abata",
                    Email = "estevens0@globo.com",
                    PhoneNumber = "+36707116870",
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
                    Name = "Tóth Becca",
                    TeamMember = "Oktatási team",
                    MembershipStart = new DateTime(2013, 5, 1),
                    UniStartYear = 2016,
                    Major = "Gazdaságinformatikus",
                    Workplace = "Feedfish",
                    Email = "becca.toth@geekclub.com",
                    PhoneNumber = "+36205127362",
                    Skype = "tothrebeka1996",
                    Slack = "Chewbecca",
                    Address = "532 Packers Park",
                    Birthday = new DateTime(1996, 03, 29),
                    PicFileName = "https://scontent.fbud2-1.fna.fbcdn.net/v/t1.0-9/16998969_1648439418516519_2295295532639880696_n.jpg?oh=19084bf79f9f494fad999fdc0284e18f&oe=5995CCCF",
                    IsAdmin = true,
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
                    PhoneNumber = "+36201273286",
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
                    PhoneNumber = "+36307088635",
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
                    PhoneNumber = "+36308026430",
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
                    PhoneNumber = "+36207868020",
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
                    PhoneNumber = "+36304573366",
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
                    PhoneNumber = "+36201550561",
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
                    PhoneNumber = "+36708737188",
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
                    PhoneNumber = "+36702143611",
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
                    PhoneNumber = "+36702320025",
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
                    PhoneNumber = "+36208348623",
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
                    PhoneNumber = "+36200162676",
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
                    PhoneNumber = "+36200474224",
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
                    PhoneNumber = "+36304671167",
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
                    PhoneNumber = "+36708070833",
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
                    PhoneNumber = "+36204086535",
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
                    PhoneNumber = "+36304166561",
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
                    PhoneNumber = "+36700872846",
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
                    PhoneNumber = "+36307665784",
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
                    PhoneNumber = "+36703018417",
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
                    PhoneNumber = "+36300787270",
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
                    PhoneNumber = "+36700803121",
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
                    PhoneNumber = "+36307141300",
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
                    PhoneNumber = "+36300870682",
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
                    PhoneNumber = "+36705622460",
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
                    PhoneNumber = "+36204056880",
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
                    PhoneNumber = "+36701344834",
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
                    PhoneNumber = "+36704164755",
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
                    PhoneNumber = "+36308608818",
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
                    PhoneNumber = "+36207643658",
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
                    PhoneNumber = "+36306304688",
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
                    PhoneNumber = "+36306083401",
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
                    PhoneNumber = "+36704254075",
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
                    PhoneNumber = "+36204386567",
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
                    PhoneNumber = "+36202266560",
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
                    PhoneNumber = "+36205247337",
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
                    PhoneNumber = "+36205555366",
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
                    PhoneNumber = "+36705516046",
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
                    PhoneNumber = "+36207360624",
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
                    PhoneNumber = "+36300545126",
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
                    PhoneNumber = "+36308028803",
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
                    PhoneNumber = "+36203880621",
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
                    PhoneNumber = "+36302487878",
                    Skype = "tbellz",
                    Slack = "tbellz",
                    Address = "36 Gerald Lane",
                    Birthday = new DateTime(1992, 2, 5),
                    PicFileName = "tbellz-5439.png",
                    IsAdmin = false,
                    IsActive = true
                } };


            foreach (var p in profiles)
            {
                await userManager.CreateAsync(p, PWD);
            }

            await context.SaveChangesAsync();
        }

        private static void AddCourses(GeekDatabaseContext context)
        {
            context.Course.AddRange(
            new Course()
            {
                CourseName = "Webfejl 1",
                DescriptionShort = "Kezdjük az alapokkal, melyeknek ismeretével akár a sitebuild (lapépítés), akár a fejlesztés és programozás során is illik felvértezni magunk. A HTML és CSS leírónyelvek a weboldal szerkezeti vázának felépítéséhez kell. Az ide tartozó parancsok a HTML5 szabvány bevezetésével sokat bővült, de az alapok elsajátítása könnyen megvalósítható. Ez a tudás egy statikus weboldal felépítéséhez már elég, illetve a nagyobb fejlesztések során is a dinamikus weboldalak vázát, úgymond sablonjait szintén így készítik el.",
                DescriptionLong = "HTML röviden, bevezetés a CSS-be (id-k, class-ok). A kurzust pedig egy mestermunkával zárjuk",
                IconFileName = "http://www.rediansoftware.com/wp-content/uploads/2017/01/custome-web-development-icon.png",
                IsWorkshop = true,
                IsActive = true,
                IsRunning = true,
                SignUpDeadline = DateTime.Today.AddDays(3)
            },

            new Course()
            {
                CourseName = "Python workshop",
                DescriptionShort = "Python workshop",
                DescriptionLong = "Python workshop py3-al",
                IconFileName = "https://cdn-img.easyicon.net/png/5404/540419.gif",
                IsWorkshop = true,
                IsActive = true,
                IsRunning = true,
                SignUpDeadline = DateTime.Today.AddDays(-5)
            },

            new Course()
            {
                CourseName = "Grafika 1",
                DescriptionShort = "A Photoshop ma a nyomdai előkészítés és képfeldolgozás legelterjedtebb programja, tudása miatt is a professzionális fotósok, webdesignerek, filmes utómunkával foglalkozó szakemberek megbecsült eszköze. A CS3 verziótól kezdve két változatban kerül forgalomba Standard és Extended.Utóbbi a Standard verzió minden szolgáltatásán kívül fejlett eszközöket tartalmaz a 3D modellezés és mozgó képek szerkesztéséhezA Standard verziót a fotósok, webes szakemberek és az amatőr felhasználóknak, míg az Extended bővített kiadást a filmesek, mérnökök és egészségügyi dolgozók számára ajánlja a gyártó.",
                DescriptionLong = "A Photoshop rétegekkel dolgozik. Ahhoz, hogy ennek lényegét megértsük, képzeljünk el négy üveglapot, amelyek mindegyikre mást rajzolunk egy filctollal. Az egyikre mondjuk egy fej körvonalát, a másikra szemet, a harmadikra fület, a negyedikre pedig egy orrot. Ha ezeket egy üveglapra rajzoltuk volna, kész lenne ugyan a fejünk, de ha elrontjuk, nem lehetne mondjuk az orrot egy picivel lejjebb csúsztatni. Szerencsére mi minden részt külön üveglapra rajzoltunk, így ha ezeket egymás fölé helyezzük, megkapjuk a kész fejet, és még külön is tudjuk mozgatni az arc elemeit hiszen mindegyik egy - egy üveglapon helyezkedik el. Photoshopban hasonlóképpen működnek a rétegek.Egy - egy üveglapot itt ? rétegnek\" vagy layernek neveznek. Minden rétegnek vannak módosítható tulajdonságai: átméretezhető, áttetszővé tehető valamennyire vagy teljesen, rajzolhatunk rá, radírozhatunk rajta stb. Az aktuális rétegen elvégzett módosítások nem lesznek hatással az alatta vagy felette lévő üveglapra (rétegekre).",
                IconFileName = "https://chakralinux.org/wiki/images/5/53/Applications-graphics.png",
                IsWorkshop = false,
                IsActive = true,
                IsRunning = true,
                SignUpDeadline = DateTime.Today.AddDays(20)
            },

            new Course()
            {
                CourseName = "UX design",
                DescriptionShort = "X, az meg micsoda? (Újabb hókusz- pókusz Nos, az UX pedig a felhasználói élmény, azaz user experience.  A felhasználói élmény nem más, mint azok a benyomások, amik a felhasználót a weboldal használata közben érik. Flottul működik minden? Amit kattinthatónak hisz a felhasználó, az valóban kattintható is? És ha igen, oda navigál általa, ahova gondolta, hogy navigálni fog? És így tovább…",
                DescriptionLong = "X, az meg micsoda? (Újabb hókusz- pókusz Nos, az UX pedig a felhasználói élmény, azaz user experience.  A felhasználói élmény nem más, mint azok a benyomások, amik a felhasználót a weboldal használata közben érik. Flottul működik minden? Amit kattinthatónak hisz a felhasználó, az valóban kattintható is? És ha igen, oda navigál általa, ahova gondolta, hogy navigálni fog? És így tovább…",
                IconFileName = "http://www.iconarchive.com/download/i34283/iconshock/brilliant-graphics/fill.ico",
                IsWorkshop = false,
                IsActive = true,
                IsRunning = false,
                SignUpDeadline = DateTime.Today.AddDays(3)
            },

            new Course()
            {
                CourseName = "BigData 1",
                DescriptionShort = "BigData 1",
                DescriptionLong = "BigData 1 a felhőben",
                IconFileName = "https://is5-ssl.mzstatic.com/image/thumb/Purple122/v4/91/61/c9/9161c94c-0927-eac9-520e-8035304d11a0/source/256x256bb.jpg",
                IsWorkshop = true,
                IsActive = false,
                IsRunning = false,
                SignUpDeadline = DateTime.Today.AddDays(20)
            },

            new Course()
            {
                CourseName = "Machine Learning (IBM Watson)",
                DescriptionShort = @"A gépi tanulás a Mesterséges Intelligencia(MI) egyik ága,
                olyan rendszerekkel foglalkoznak,
                melyek tanulni képesek,
                azaz tapasztalatokból tudást generálnak.A gyakorlatban ez azt jelenti,
                hogy a rendszer példa adatok,
                minták alapján képes önállóan,
                vagy emberi segítséggel szabályszerűségeket / szabályokat felismerni / meghatározni.A rendszer tehát nem csupán betanulja „kívülről” mintákat,
                hanem képes ezek alapján olyan általánosításra,
                ami alapján – a tanulási szakasz végeztével – ismeretlen adatokra vonatkozólag is „helyes” döntéseket tud hozni.",
                DescriptionLong = "A gépi tanulás a Mesterséges Intelligencia (MI) egyik ága, olyan rendszerekkel foglalkoznak, melyek tanulni képesek, azaz tapasztalatokból tudást generálnak. A gyakorlatban ez azt jelenti, hogy a rendszer példa adatok, minták alapján képes önállóan, vagy emberi segítséggel szabályszerűségeket/szabályokat felismerni/meghatározni. A rendszer tehát nem csupán betanulja „kívülről” mintákat, hanem képes ezek alapján olyan általánosításra, ami alapján – a tanulási szakasz végeztével – ismeretlen adatokra vonatkozólag is „helyes” döntéseket tud hozni.",
                IconFileName = "http://www.crescointl.com/wp-content/uploads/2016/05/ibm.png",
                IsWorkshop = true,
                IsActive = true,
                IsRunning = false,
                SignUpDeadline = DateTime.Today.AddDays(8)
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
                    ActualDate = DateTime.Now.AddDays(-2),
                    Title = "Ismerkedés a HTML-el",
                    Description = "Ismerkedés a HTML-el"
                },
                new CourseThematics()
                {
                    CourseId = id,
                    WeekNumber = 2,
                    ActualDate = DateTime.Now.AddDays(5),
                    Title = "CSS alapok",
                    Description = "CSS bevezető"
                },
                new CourseThematics()
                {
                    CourseId = id,
                    WeekNumber = 3,
                    ActualDate = DateTime.Now.AddDays(12),
                    Title = "CSS",
                    Description = "Advanced CSS"
                },
                new CourseThematics()
                {
                    CourseId = id,
                    WeekNumber = 4,
                    ActualDate = DateTime.Now.AddDays(19),
                    Title = "SASS",
                    Description = "Bevezetés a SASS-be"
                }
                );

            Course p = context.Course.First(c => c.CourseName == "Python workshop");
            id = p.CourseId;
            context.CourseThematics.AddRange(
                new CourseThematics()
                {
                    CourseId = id,
                    WeekNumber = 1,
                    ActualDate = DateTime.Now.AddDays(-2),
                    Title = "Ismerkedés a Python-al",
                    Description = "Ismerkedés a Python-al"
                },
                new CourseThematics()
                {
                    CourseId = id,
                    WeekNumber = 2,
                    ActualDate = DateTime.Now.AddDays(5),
                    Title = "Python alapok",
                    Description = "Alap típusok, Operátorok"
                });

            Course graf = context.Course.First(c => c.CourseName == "Grafika 1");
            id = graf.CourseId;
            context.CourseThematics.AddRange(
                new CourseThematics()
                {
                    CourseId = id,
                    WeekNumber = 1,
                    ActualDate = DateTime.Now.AddDays(-2),
                    Title = "Ismerkedés a Photoshop",
                    Description = "Ismerkedés a Photoshop CC-al"
                },
                new CourseThematics()
                {
                    CourseId = id,
                    WeekNumber = 2,
                    ActualDate = DateTime.Now.AddDays(5),
                    Title = "Photoshop rétegek",
                    Description = "Photoshop rétegek bevezető"
                });

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

            context.CourseEnrollment.Add(new CourseEnrollment()
            {
                ProfileId = 1,
                CourseId = 1,
                IsInstructor = true
            });

            context.CourseEnrollment.Add(new CourseEnrollment()
            {
                ProfileId = 1,
                CourseId = 2,
                IsInstructor = true
            });
            context.CourseEnrollment.Add(new CourseEnrollment()
            {
                ProfileId = 2,
                CourseId = 1,
                IsInstructor = true
            });

            context.CourseEnrollment.Add(new CourseEnrollment()
            {
                ProfileId = 2,
                CourseId = 2,
                IsInstructor = true
            });

            context.CourseEnrollment.Add(new CourseEnrollment()
            {
                ProfileId = 8,
                CourseId = 1,
                IsInstructor = true
            });

            context.CourseEnrollment.Add(new CourseEnrollment()
            {
                ProfileId = 3,
                CourseId = 3,
                IsInstructor = true
            });

            context.CourseEnrollment.Add(new CourseEnrollment()
            {
                ProfileId = 4,
                CourseId = 1,
                IsInstructor = true
            });

            context.CourseEnrollment.Add(new CourseEnrollment()
            {
                ProfileId = 5,
                CourseId = 2,
                IsInstructor = true
            });


            context.SaveChanges();
        }

        private static void AddHomeworkUploads(GeekDatabaseContext context)
        {
            int course_id = context.Course.First(c => c.CourseName == "Webfejl 1").CourseId;
            context.HomeworkUpload.AddRange(
                new HomeworkUpload() { CourseId = course_id, WeekNumber = 1, UploadFileName = "hazi1.zip", Comment = "Hazi Feladat 1", UploadDateTime = DateTime.Now.AddDays(-4), ProfileId = context.Profile.First(p => p.Name == "Jack Grant").Id, IsActive = true },
                new HomeworkUpload() { CourseId = course_id, WeekNumber = 1, UploadFileName = "web.zip", Comment = "1. Hazi Feladat", UploadDateTime = DateTime.Now.AddDays(-3), ProfileId = context.Profile.First(p => p.Name == "Thomas Scott").Id, IsActive = false },
                new HomeworkUpload() { CourseId = course_id, WeekNumber = 1, UploadFileName = "uj-web.zip", Comment = "Javitott 1. Hazi Feladat", UploadDateTime = DateTime.Now.AddDays(-2), ProfileId = context.Profile.First(p => p.Name == "Thomas Scott").Id, IsActive = true }
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
                new List<String>() { "Howard Freeman", "Webfejlesztes", "5" },
                new List<String>() { "Howard Freeman", "UX design", "3" },
                new List<String>() { "Howard Freeman", "Grafika", "4" },
                new List<String>() { "Evelyn Stevenson", "UX design", "5" },
                new List<String>() { "Evelyn Stevenson", "Webfejlesztes", "1" },
                new List<String>() { "Cheryl Wallace", "Grafika", "4" },
                new List<String>() { "Cheryl Wallace", "Webfejlesztes", "2" },
                new List<String>() { "Roger Romero", "Webfejlesztes", "3" },
                new List<String>() { "Jack Grant", "Webfejlesztes", "3" },
                new List<String>() { "Jack Grant", "UX design", "1" },
                new List<String>() { "Tina Carr", "Grafika", "2" }
            };
            foreach (var map in maps)
            {
                int profile_id = context.Profile.First(e => e.Name == map[0]).Id;
                int comp_id = context.Competency.First(e => e.CompetencyName == map[1]).CompetencyId;
                context.MemberCompetency.Add(new MemberCompetency() { ProfileId = profile_id, CompetencyId = comp_id, CompetencyLvl = int.Parse(map[2]), CompetencyComment = $"{map[1]} skill" });
            }
            context.SaveChanges();
        }

        private static void AddGalleries(GeekDatabaseContext context)
        {
            var evelyn = context.Profile.First(p => p.Name == "Evelyn Stevenson");

            context.GalleryAlbum.AddRange(new GalleryAlbum()
            { Name = "Taggyules", Creator = evelyn, CreatedAt = DateTime.Now.AddDays(-6) },
            new GalleryAlbum()
            { Name = "Kirandulas", Creator = evelyn, CreatedAt = DateTime.Now.AddDays(-4) });

            context.SaveChanges();
            var album = context.GalleryAlbum.First(a => a.Name == "Taggyules");
            for (int i = 1; i < 6; i++)
            {
                album.GalleryPicture.Add(new GalleryPicture() { Filename = $"1-sd{i}.jpg", Uploader = evelyn, UploadedAt = DateTime.Now.AddHours(-i-50) });
            }

            album = context.GalleryAlbum.First(a => a.Name == "Kirandulas");
            for (int i = 1; i < 5; i++)
            {
                album.GalleryPicture.Add(new GalleryPicture() { Filename = $"2-sd{i}.jpg", Uploader = evelyn, UploadedAt = DateTime.Now.AddHours(-i) });
            }

            context.SaveChanges();
        }
    }
}
