using System;
using System.Collections.Generic;
using System.Text;

namespace MuziekSpeler
{
    public class ID3Parser
    {
        ///<summary>
        /// An ID3 parser,
        /// ID3V2 tags start with a header. The first three bytes of this header are [73], [68] & [51]
        /// This decodes to "ID3" according to ISO-8859-1 characters.
        /// 
        /// Then come two bytes that encode the major versiaon and revision of the ID3 speciffication to which the tag purports to conform.
        /// Afterwards a single byte whose bits are treated as flags. The meaning of which depend on the spec version.
        /// 
        /// The last field in the tag header is an integer, encoded in four bytes but only seven bits from each byte, that gives
        /// the total size of the tag, not counting the header. in V2.3 this may be followed by several extended header fields. 
        /// 
        /// Otherwise the remainder of the tag data is divided into frames. Frames store different information, from song name to album cover.
        /// Each frame starts with a header containing a string identifier and a size. in v 2.3, the frame header also contains two bytes worth of flags
        /// and depending on the value of one of the flags, an optional one-byte code indicating how the rest of the frame is encrypted.
        /// 
        /// To parse a frame you first need to figure out what type of frame it is by analyzing the header and by use of the identifier.
        /// The only way to get the number of frames is to read said data.
        /// 
        /// Main problem: ==>  Reading the ID3 header; is it v2.2 or v2.3; and reading the frame data, stopping either when you've
        /// read the complete tag or whe you've hit the padding bytes.
        /// 
        /// </summary>
    }
}





/* an ID3 v1.0 parser.
 * class MusicID3Tag
    {   // Might only work for ID3v1 tags, need to figure this out for myself proper... 
        public byte[] TAGID = new byte[3];
        public byte[] Title = new byte[30];
        public byte[] Artist = new byte[30];
        public byte[] Album = new byte[30];
        public byte[] Year = new byte[4];
        public byte[] Comment = new byte[30];
        public byte[] Genre = new byte[1];

        public string path;

        public string[] GetTags()
        {
            using (FileStream fs = File.OpenRead(path))
            {
                if (fs.Length >= 128)
                {
                    MusicID3Tag tag = new MusicID3Tag();
                    fs.Seek(-128, SeekOrigin.End);
                    fs.Read(TAGID, 0, tag.TAGID.Length);
                    fs.Read(Title, 0, tag.Title.Length);
                    fs.Read(Artist, 0, tag.Artist.Length);
                    fs.Read(Album, 0, tag.Album.Length);
                    fs.Read(Year, 0, tag.Year.Length);
                    fs.Read(Comment, 0, tag.Comment.Length);
                    fs.Read(Genre, 0, tag.Genre.Length);
                    string theTAGID = Encoding.Default.GetString(tag.TAGID);

                    if (theTAGID.Equals("TAG"))
                    {
                        string Title = Encoding.Default.GetString(tag.Title);
                        string Artist = Encoding.Default.GetString(tag.Artist);
                        string Album = Encoding.Default.GetString(tag.Album);
                        string Year = Encoding.Default.GetString(tag.Year);
                        string Comment = Encoding.Default.GetString(tag.Comment);
                        string Genre = Encoding.Default.GetString(tag.Genre);

                        return new string[] {Title, Artist, Album, Year, Comment, Genre };
                    }
                }
            }
            return null;
        }
    }*/
