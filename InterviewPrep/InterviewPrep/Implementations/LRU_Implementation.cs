using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.Implementations
{
    public class LRU
    {
        DLLNode stale;
        DLLNode latest;
        int _cap;
        int count;

        Dictionary<int, DLLNode> dict = new Dictionary<int, DLLNode>();

        public LRU(int cap)
        {
            _cap = cap;
        }
        public int GetItem(int uid)
        {
            return dict[uid].value;
        }

        public void PutItem(int uuid, int item)
        {
            DLLNode node = new DLLNode(item);

            if (count == 0)
            {
                node.next = new DLLNode();
                node.prev = new DLLNode();
                stale = node;
                latest = node;
                dict.Add(uuid, node);
                count++;
            }
            else if (!dict.ContainsKey(uuid) && count < _cap)
            {
                DLLNode temp = latest;
                latest = node;
                latest.prev = temp;
                latest.next = new DLLNode();

                dict.Add(uuid, node);
                count++;
            }
            else if (!dict.ContainsKey(uuid) && count == _cap)
            {
                DLLNode temp = stale;
                stale = stale.next;
                stale.prev = new DLLNode();
                stale.next = temp;

                latest = node;
                latest.prev = temp;
                latest.next = new DLLNode();

                dict.Add(uuid, node);
            }

            else if (dict.ContainsKey(uuid))
            {
                DLLNode temp = stale;
                stale = stale.next;
                stale.prev = new DLLNode();
                stale.next = temp;

                latest = node;
                latest.prev = temp;
                latest.next = new DLLNode();

                dict[uuid] = node;
            }
        }
    }
}
