using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class MemberRepository : IMemberRepository
    {
        public MemberObject GetMemberByID(int memId) => MemberDAO.Instance.GetMemberByID(memId);

        public IEnumerable<MemberObject> GetMemberObjects() => MemberDAO.Instance.GetMemberList;

        public void InsertMember(MemberObject mem) => MemberDAO.Instance.AddNew(mem);

        public void DeleteMember(int memId) => MemberDAO.Instance.Remove(memId);

        public void UpdateMember(MemberObject mem) => MemberDAO.Instance.Update(mem); 
    }
}
