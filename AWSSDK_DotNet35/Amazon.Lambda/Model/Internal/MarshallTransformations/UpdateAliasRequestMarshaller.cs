/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the lambda-2015-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Lambda.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Lambda.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateAlias Request Marshaller
    /// </summary>       
    public class UpdateAliasRequestMarshaller : IMarshaller<IRequest, UpdateAliasRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateAliasRequest)input);
        }

        public IRequest Marshall(UpdateAliasRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Lambda");
            request.Headers["Content-Type"] = "application/x-amz-json-";
            request.HttpMethod = "PUT";

            string uriResourcePath = "/2015-03-31/functions/{FunctionName}/aliases/{Name}";
            uriResourcePath = uriResourcePath.Replace("{FunctionName}", publicRequest.IsSetFunctionName() ? StringUtils.FromString(publicRequest.FunctionName) : string.Empty);
            uriResourcePath = uriResourcePath.Replace("{Name}", publicRequest.IsSetName() ? StringUtils.FromString(publicRequest.Name) : string.Empty);
            request.ResourcePath = uriResourcePath;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetDescription())
                {
                    context.Writer.WritePropertyName("Description");
                    context.Writer.Write(publicRequest.Description);
                }

                if(publicRequest.IsSetFunctionVersion())
                {
                    context.Writer.WritePropertyName("FunctionVersion");
                    context.Writer.Write(publicRequest.FunctionVersion);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }


    }
}