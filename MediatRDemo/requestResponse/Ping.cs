using System;
using System.Collections.Generic;
using System.Text;
using MediatR;

namespace MediatRDemo.requestResponse
{
    /*注意：请求/响应接口适用于命令和查询场景。
 *都只能有一个Handler，如果注册多个，只有最后一个会生效。
 */
    public class Ping : IRequest<string>
    {
        public int MsgId { get; set; }
    }

    

}
