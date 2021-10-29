﻿using System;
using System.Collections.Generic;
using System.Text;

namespace leet.LeetCode.Models
{
    public class Node
    {
        public int val;
        public Node next;
        public Node random;

        public Node(int _val)
        {
            val = _val;
            next = null;
            random = null;
        }
    }
}
