using Amazon;
using Amazon.S3;
using Amazon.S3.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AwsFileSystem
{
     public class AWSServer
    {

        private static AWSServer instance;

        private string access_key;

        private string secret_key;

        private RegionEndpoint region;

        private AWSServer() { }

        public static AWSServer getInstance()
        {
            if (instance == null)
            {
                instance = new AWSServer();
            }

            return instance;
        }

        public void SetAccountAWS(string _access_key, string _secret_key, RegionEndpoint _region)
        {
            access_key = _access_key;
            secret_key = _secret_key;
            region = _region;
        }

        public async Task<List<S3Bucket>> ConnectS3()
        {

            // Khởi tạo client AWS S3
            var s3Client = new AmazonS3Client(access_key, secret_key, region);

            var buckets = await GetBucketList(s3Client);

            return buckets.Buckets;

        }       

        public static async Task<ListBucketsResponse> GetBucketList(IAmazonS3 Client)
        {
            return await Client.ListBucketsAsync();
        }

        public void Disconnect()
        {

        }

    }
}
