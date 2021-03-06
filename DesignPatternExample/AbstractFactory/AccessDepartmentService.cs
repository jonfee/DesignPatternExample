﻿using System;

namespace DesignPatternExample.AbstractFactory
{
    public class AccessDepartmentService : IDepartmentService
    {
        public Department GetDepartmentById(int id)
        {
            Console.WriteLine("在Access中从Department表中获取一条部门信息");

            return new Department { Id = id, Name = "人力资源部" };
        }
    }
}
