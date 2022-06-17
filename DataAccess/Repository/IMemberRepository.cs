﻿using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IMemberRepository
    {
        IEnumerable<MemberObject> GetMemberObjects();
        MemberObject GetMemberByID(int memId);
        void InsertMember(MemberObject mem);
        void DeleteMember(int memId);
        void UpdateMember(MemberObject mem);
    }
}
