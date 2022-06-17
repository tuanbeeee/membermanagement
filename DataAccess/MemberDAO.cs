using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class MemberDAO
    {
        public static List<MemberObject> MemberList = new List<MemberObject>()
        {
         new MemberObject{MemberID=1,MemberName="TuanBe",City="BRVT",Country="VN", Email="tuanblep@gmail.com", Password="1", DateOfBirth=DateTime.Parse("8/29/2001")},
         new MemberObject{MemberID=2,MemberName="ThaiSan",City="LA",Country="VN", Email="tuanblep0298@gmail.com", Password="1", DateOfBirth=DateTime.Parse("8/29/2001")},
         new MemberObject{MemberID=3,MemberName="HaiSan",City="HCM",Country="VN", Email="haisan@gmail.com", Password="1", DateOfBirth=DateTime.Parse("8/29/2001")},
         new MemberObject{MemberID=4,MemberName="Ducky",City="BD",Country="CAM", Email="ducsan@gmail.com", Password="1", DateOfBirth=DateTime.Parse("8/29/2001")},
         new MemberObject{MemberID=5,MemberName="HieuXaoLoz",City="LA",Country="CAM", Email="hieusan@gmail.com", Password="1", DateOfBirth=DateTime.Parse("8/29/2001")},
         new MemberObject{MemberID=6,MemberName="TuanBe",City="BRVT",Country="CAM", Email="tuansan@gmail.com", Password="1", DateOfBirth=DateTime.Parse("8/29/2001")}
        };

        private static MemberDAO instance = null;
        private static readonly object instanceLock = new Object();

        private MemberDAO() { }

        public static MemberDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new MemberDAO();
                    }
                    return instance;
                }
            }
        }
        public List<MemberObject> GetMemberList => MemberList;
        
        public MemberObject GetMemberByID(int MemberID)
        {
            MemberObject mem = MemberList.SingleOrDefault(pro => pro.MemberID == MemberID);
            return mem;
        }

        public void AddNew(MemberObject mem)
        {
            MemberObject pro = GetMemberByID(mem.MemberID);
            if (pro == null)
            {
                MemberList.Add(mem);
            }
            else
            {
                throw new Exception("User is already exists!");
            }
        }

        public void Update(MemberObject mem)
        {
            MemberObject m = GetMemberByID(mem.MemberID);
            if (m != null)
            {
                var index = MemberList.IndexOf(m);
                MemberList[index] = mem;
            }
            else
            {
                throw new Exception("User does not already exists.");
            }
        }

        public void Remove(int MemberID)
        {
            MemberObject m = GetMemberByID(MemberID);
            if (m != null)
            {
                MemberList.Remove(m);
            }
            else
            {
                throw new Exception("User does not already exists.");
            }
        }
    }
}
