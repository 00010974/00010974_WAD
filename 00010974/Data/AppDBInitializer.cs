using Microsoft.AspNetCore.Builder;
using System.Collections.Generic;
using System;
using Microsoft.Extensions.DependencyInjection;
using _00010974.Models;
using System.Linq;
using _00010974.Data.Enums;

namespace _00010974.Data
{
    public class AppDBInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();


                //Publishers 
                if (!context.Publishers.Any())
                {
                    context.Publishers.AddRange(new List<Publishers>()
                    {
                        new Publishers()
                        {
                            Title = "Disney Hyperion",
                            Bio = "The one you can’t put down. The one you’ll never forget. The one that makes you laugh out loud. The one that made you sob even louder.",

                        },
                        new Publishers()
                        {
                            Title = "Audible Studios",
                            Bio = "Audible Originals are exclusive audio titles created by celebrated storytellers from worlds as diverse as theater, journalism, literature and more, all produced in the Audible studios.",
                        },
                        new Publishers()
                        {
                            Title = "Simon & Schuster",
                            Bio = "Some best-selling titles include Heart Bones, It Starts with Us genre busting horror novels Beneath the Stairs and The Orinoco Uranium",

                        },
                        new Publishers()
                        {
                            Title = "Margaret K. McElderry Books",
                            Bio = "Founded by legendary editor Margaret K. McElderry in 1972, Margaret K. McElderry Books is a boutique imprint of Simon & Schuster’s Children’s Division, recognized internationally as a publisher of literary author-driven fiction and nonfiction for the teen, middle grade, picture book, and poetry markets. ",
                        },
                        new Publishers()
                        {
                            Title = "Quirk Books",
                            Bio = "Some of Quirk’s best-selling titles include Miss Peregrine’s Home for Peculiar Children, Grady Hendrix’s genre busting horror novels My Best Friend’s Exorcism and The Southern Book Club’s Guide to Slaying Vampires, the legendary mash-up Pride and Prejudice and Zombies, The Baby Owner’s Manual, and The Astrology of You and Me. While headquartered on a cobblestone street in historic Old City, Philadelphia, Quirk’s books are distributed worldwide by Penguin Random House and available wherever books are sold.",
                        },
                    });
                    context.SaveChanges();
                }

                //Authors
                if (!context.Authors.Any())
                {
                    context.Authors.AddRange(new List<Authors>()
                    {
                        new Authors()
                        {
                            AuthorPicture = "https://m.media-amazon.com/images/W/IMAGERENDERING_521856-T1/images/I/61w3pqVMCZL.jpg",
                            FullName = "Rick Riordan",
                            AuthorBooks = "Percy Jackson Series, Olimpians, Magnus Chaise and Gods of Asgard"
                        },
                        new Authors()
                        {
                            AuthorPicture = "https://upload.wikimedia.org/wikipedia/commons/thumb/3/38/Montreuil_-_Salon_du_livre_jeunesse_2012_-_Ransom_Riggs_-_002.jpg/1200px-Montreuil_-_Salon_du_livre_jeunesse_2012_-_Ransom_Riggs_-_002.jpg",
                            FullName = "Ransom Riggs",
                            AuthorBooks = "Miss Perigrin`s Peculiar Children series"
                        },
                        new Authors()
                        {
                            AuthorPicture = "https://images.gr-assets.com/authors/1445955959p8/1630.jpg",
                            FullName = "Ray Bradbury",
                            AuthorBooks = "The Golden Apples of the Sun, Dandelion Wine, Something Wicked This Way Comes, Green Shadows, White Whale"
                        },
                        new Authors()
                        {
                            AuthorPicture = "https://m1.paperblog.com/i/281/2814387/cassandra-clare-L-sPMKwo.png",
                            FullName = "Cassandra Clare",
                            AuthorBooks = "The Mortal Instruments, The Dark Artifices, The Last Hours"
                        },
                    });
                    context.SaveChanges();
                }

                //Books
                if (!context.Books.Any())
                {
                    context.Books.AddRange(new List<Books>()
                    {
                        new Books()
                        {
                            ImgUrl = "https://cdn.penguin.co.uk/dam-assets/books/9780141325507/9780141325507-jacket-large.jpg",
                            Title = "The Red Pyramid",
                            AuthorName = "Rick Riordan",
                            Series = Series.TheKaneChronicles,
                            Price = (int)10,
                            Genre = Genre.Fantasy,
                            PublishingHouse = "Disney Hyperion",
                            Description = "One night, Dr. Kane brings the siblings together for a \"research experiment\" at the British Museum, where he hopes to set things right for his family. Instead, he unleashes the Egyptian god Set, who banishes him to oblivion and forces the children to flee for their lives.",
                            AuthorId = 1
                        },
                        new Books()
                        {
                            ImgUrl = "https://m.media-amazon.com/images/W/IMAGERENDERING_521856-T1/images/I/91tJAt3Yk7L.jpg",
                            Title = "The Throne of Fire",
                            AuthorName = "Rick Riordan",
                            Series = Series.TheKaneChronicles,
                            Price = (int)15,
                            Genre = Genre.Fantasy,
                            PublishingHouse = "Disney Hyperion",
                            Description = "In this exciting second installment of the three-book series, Carter and Sadie, offspring of the brilliant Egyptologist Dr. Julius Kane",
                            AuthorId = 1
                        },
                        new Books()
                        {
                            ImgUrl = "https://books.disney.com/content/uploads/2017/08/9781484781326-327x462.jpg",
                            Title = "The Serpent`s Shadow",
                            AuthorName = "Rick Riordan",
                            Series = Series.TheKaneChronicles,
                            Price = (int)13,
                            Genre = Genre.Fantasy,
                            PublishingHouse = "Disney Hyperion",
                            Description = "He`s b-a-a-ack! Despite their best efforts, Carter and Sadie Kane can`t seem to keep Apophis, the chaos snake, down.",
                            AuthorId = 1
                        },
                        new Books()
                        {
                            ImgUrl = "https://m.media-amazon.com/images/W/IMAGERENDERING_521856-T1/images/I/91GXC09xGBL._AC_UF1000,1000_QL80_.jpg",
                            Title = "Library of Souls",
                            AuthorName = "Ransom Riggs",
                            Series = Series.HomeForPeculiarChildren,
                            Price = (int)14,
                            Genre = Genre.Thriller,
                            PublishingHouse = "Quirk Books",
                            Description = "A boy with extraordinary powers. An army of deadly monsters. An epic battle for the future of peculiardom.",
                            AuthorId = 2
                        },
                        new Books()
                        {
                            ImgUrl = "https://m.media-amazon.com/images/W/IMAGERENDERING_521856-T1/images/I/518WxaFw0rL._AC_UF1000,1000_QL80_.jpg",
                            Title = "The Martian Chronicles",
                            AuthorName = "Ray Bradbury",
                            Series = Series.None,
                            Price = (int)9,
                            Genre = Genre.ScienceFiction,
                            PublishingHouse = "Audible Studios",
                            Description = "Mars was a distant shore, and the men spread upon it in wave.... Each wave different, and each wave stronger.",
                            AuthorId = 3
                        },
                        new Books()
                        {
                            ImgUrl = "https://m.media-amazon.com/images/W/IMAGERENDERING_521856-T1/images/I/61z7RDG3OIL._AC_UF1000,1000_QL80_.jpg",
                            Title = "Fahrenheit 451",
                            AuthorName = "Ray Bradbury",
                            Series = Series.None,
                            Price = (int)8,
                            Genre = Genre.ScienceFiction,
                            PublishingHouse = "Simon & Schuster",
                            Description = "Guy Montag is a fireman. His job is to destroy the most illegal of commodities, the printed book, along with the houses in which they are hidden.",
                            AuthorId = 3
                        },
                        new Books()
                        {
                            ImgUrl = "https://m.media-amazon.com/images/W/IMAGERENDERING_521856-T1/images/I/71kYIeAK8yL._AC_UF1000,1000_QL80_.jpg",
                            Title = "The Illustrated Man",
                            AuthorName = "Ray Bradbury",
                            Series = Series.None,
                            Price = (int)10,
                            Genre = Genre.ScienceFiction,
                            PublishingHouse = "Simon & Schuster",
                            Description = "The Illustrated Man is a kaleidoscopic blending of magic, imagination, and truth",
                            AuthorId = 3
                        },

                        new Books()
                        {
                            ImgUrl = "http://starcrossedbookblog.com/wp-content/uploads/2018/12/813Wa1PogL.jpg",
                            Title = "City of Bones",
                            AuthorName = "Cassandra Clare",
                            Series = Series.TheMortalInstruments,
                            Price = (int)13,
                            Genre = Genre.Fantasy,
                            PublishingHouse = "Margaret K. McElderry Books",
                            Description = "When fifteen-year-old Clary Fray heads out to the Pandemonium Club in New York City, she hardly expects to witness a murder",
                            AuthorId = 4
                        },
                        new Books()
                        {
                            ImgUrl = "https://kbimages1-a.akamaihd.net/fdbceff7-ef98-4204-af13-1b4e6c10db3f/1200/1200/False/city-of-ashes-4.jpg",
                            Title = "City of Ashes",
                            AuthorName = "Cassandra Clare",
                            Series = Series.TheMortalInstruments,
                            Price = (int)22,
                            Genre = Genre.Fantasy,
                            PublishingHouse = "Margaret K. McElderry Books",
                            Description = "Clary Fray just wishes that her life would go back to normal. But what`s normal when you`re a demon-slaying Shadowhunter, your mother is in a magically induced coma, and you can suddenly see Downworlders like werewolves, vampires, and faeries?",
                            AuthorId = 4
                        },
                        new Books()
                        {
                            ImgUrl = "https://m.media-amazon.com/images/W/IMAGERENDERING_521856-T1/images/I/81f73W7uSxL.jpg",
                            Title = "City of Glass",
                            AuthorName = "Cassandra Clare",
                            Series = Series.TheMortalInstruments,
                            Price = (int)24,
                            Genre = Genre.Fantasy,
                            PublishingHouse = "Margaret K. McElderry Books",
                            Description = "Love is a mortal sin, and the secrets of the past are deadly. Plunge into the third installment in the internationally bestselling Mortal Instruments series and “prepare to be hooked” ",
                            AuthorId = 4
                        },
                        new Books()
                        {
                            ImgUrl = "https://images.thalia.media/-/BF2000-2000/d9133e89d2e34ab5a8642027cc6724a4/city-of-fallen-angels-taschenbuch-cassandra-clare.jpeg",
                            Title = "City of Fallen Angels",
                            AuthorName = "Cassandra Clare",
                            Series = Series.TheMortalInstruments,
                            Price = (int)20,
                            Genre = Genre.Fantasy,
                            PublishingHouse = "Margaret K. McElderry Books",
                            Description = "With Valentine out of the way, Clary thought she and Jace could finally be together--but when someone starts murdering the Shadowhunters ",
                            AuthorId = 4
                        },
                        new Books()
                        {
                            ImgUrl = "https://m.media-amazon.com/images/W/IMAGERENDERING_521856-T1/images/I/81ugWwaH2+L.jpg",
                            Title = "City of Lost Souls",
                            AuthorName = "Cassandra Clare",
                            Series = Series.TheMortalInstruments,
                            Price = (int)13,
                            Genre = Genre.Fantasy,
                            PublishingHouse = "Margaret K. McElderry Books",
                            Description = "When Jace and Clary meet again, Clary is horrified to discover that the demon Lilith’s magic has bound her beloved Jace together with her evil brother Sebastian, and that Jace has become a servant of evil.",
                            AuthorId = 4
                        },
                        new Books()
                        {
                            ImgUrl = "https://m.media-amazon.com/images/W/IMAGERENDERING_521856-T1/images/I/51T+BEX3umL.jpg",
                            Title = "City of Heavenly Fire",
                            AuthorName = "Cassandra Clare",
                            Series = Series.TheMortalInstruments,
                            Price = (int)13,
                            Genre = Genre.Fantasy,
                            PublishingHouse = "Margaret K. McElderry Books",
                            Description = "Darkness has descended on the Shadowhunter world. Chaos and destruction overwhelm the Nephilim as Clary, Jace, Simon, and their friends band together to fight the greatest evil they have ever faced: Clary’s own brother. ",
                            AuthorId = 4
                        },


                    });
                    context.SaveChanges();
                }

                //Books_Publishers
                if (!context.Books_Publishers.Any())
                {
                    context.Books_Publishers.AddRange(new List<Books_Publishers>()
                    {
                        new Books_Publishers()
                        {
                            BooksId = 1,
                            PublishersId = 1
                        },
                        new Books_Publishers()
                        {
                            BooksId = 2,
                            PublishersId = 1
                        },
                        new Books_Publishers()
                        {
                            BooksId = 3,
                            PublishersId = 1
                        },
                        new Books_Publishers()
                        {
                            BooksId = 5,
                            PublishersId = 2
                        },
                        new Books_Publishers()
                        {
                            BooksId = 6,
                            PublishersId = 3
                        },
                        new Books_Publishers()
                        {
                            BooksId = 7,
                            PublishersId = 3
                        },
                        new Books_Publishers()
                        {
                            BooksId = 8,
                            PublishersId = 4
                        },
                        new Books_Publishers()
                        {
                            BooksId = 9,
                            PublishersId = 4
                        },
                        new Books_Publishers()
                        {
                            BooksId = 10,
                            PublishersId = 4
                        },
                        new Books_Publishers()
                        {
                            BooksId = 11,
                            PublishersId = 4
                        },
                        new Books_Publishers()
                        {
                            BooksId = 12,
                            PublishersId = 4
                        },
                        new Books_Publishers()
                        {
                            BooksId = 13,
                            PublishersId = 4
                        },
                        new Books_Publishers()
                        {
                            BooksId = 4,
                            PublishersId = 5
                        },

                    });
                    context.SaveChanges();
                }
            }

        }

    }
}
