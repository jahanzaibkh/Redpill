using System;
using System.ServiceModel;

namespace RedPill
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IRedPill" in both code and config file together.
    [ServiceContract(Namespace = "http://KnockKnock.readify.net")]
    public interface IRedPill
    {

        [OperationContract(Action = "http://KnockKnock.readify.net/IRedPill/WhatIsYourToken", ReplyAction = "http://KnockKnock.readify.net/IRedPill/WhatIsYourToken")]
        Guid WhatIsYourToken();

       [OperationContract(Action = "http://KnockKnock.readify.net/IRedPill/FibonacciNumber", ReplyAction = "http://KnockKnock.readify.net/IRedPill/FibonacciNumber")]
        [FaultContract(typeof(ArgumentOutOfRangeException))]
        long FibonacciNumber(long n);

       [OperationContract(Action = "http://KnockKnock.readify.net/IRedPill/ReverseWords", ReplyAction = "http://KnockKnock.readify.net/IRedPill/ReverseWords")]
        [FaultContract(typeof(ArgumentNullException))]
        string ReverseWords(string s);

        [OperationContract(Action = "http://KnockKnock.readify.net/IRedPill/WhatShapeIsThis", ReplyAction = "http://KnockKnock.readify.net/IRedPill/WhatShapeIsThis")]
        TriangleType WhatShapeIsThis(int a, int b, int c);
    }
}
