using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BirdWatcher
{
    [Serializable]
    public class BirdData
    {
        private Guid mId;
        private string mBirdName;
       
        private string mHabitat;
        private string mBehaviorObserved;
        private DateTime mDateViewed;
        
        private byte[] mPicture;
        private string mPictureName;


        public BirdData()
        {
            mId = Guid.NewGuid();
        }
        public BirdData(string birdname)
        {
            mId = Guid.NewGuid();
            mBirdName = birdname;
        }
        public Guid ID
        {
            get
            {
                return mId;
            }
        }


        public string BirdName
        {
            get
            {
                return mBirdName;
            }
            set
            {
                mBirdName = value;
            }
        }


        


        public string Habitat
        {
            get
            {
                return mHabitat;
            }
            set
            {
                mHabitat = value;
            }
        }


        public string BehaviorObserved
        {
            get
            {
                return mBehaviorObserved;
            }
            set
            {
                mBehaviorObserved = value;
            }
        }


        public DateTime DateViewed
        {
            get
            {
                return mDateViewed;
            }
            set
            {
                mDateViewed = value;
            }
        }


       


        public byte[] Picture
        {
            get
            {
                return mPicture;
            }
            set
            {
                mPicture = value;
            }
        }

        public string PictureName
        {
            get
            {
                return mPictureName;
            }
            set
            {
                mPictureName = value;
            }
        }



    }

}
