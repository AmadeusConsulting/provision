﻿namespace Provision.Providers.Redis
{
    using System.Reflection;

    using Provision.Models;

    public class RedisCacheHandlerConfiguration : BaseCacheHandlerConfiguration
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RedisCacheHandlerConfiguration"/> class.
        /// </summary>
        public RedisCacheHandlerConfiguration()
            : base("redis", typeof(RedisCacheHandler).GetTypeInfo())
        {
            this.Options["host"] = "localhost";
            this.Options["port"] = 6379;
            this.Options["database"] = 0;
            this.Options["compress"] = false;
            this.Options["maxZipMapEntries"] = 512;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RedisCacheHandlerConfiguration" /> class.
        /// </summary>
        /// <param name="host">The host.</param>
        /// <param name="port">The port.</param>
        /// <param name="database">The database.</param>
        /// <param name="password">The password.</param>
        /// <param name="prefix">The prefix.</param>
        /// <param name="maxZipMapEntries">The maximum number of zip map entries.</param>
        /// <param name="loggerName">The logger name.</param>
        /// <param name="compress">if set to <c>true</c> [compress].</param>
        public RedisCacheHandlerConfiguration(string host = "localhost", int port = 6379, int database = 0, string password = null, string prefix = null, int maxZipMapEntries = 512, string loggerName = null, bool compress = false)
            : base("redis", typeof(RedisCacheHandler).GetTypeInfo())
        {
            this.Options["host"] = host;
            this.Options["port"] = port;
            this.Options["database"] = database;
            this.Options["password"] = password;
            this.Options["prefix"] = prefix;
            this.Options["loggerName"] = loggerName;
            this.Options["compress"] = compress;
            this.Options["maxZipMapEntries"] = maxZipMapEntries;
        }

        /// <summary>
        /// Gets the name of the logger.
        /// </summary>
        /// <value>The name of the logger.</value>
        public string LoggerName
        {
            get
            {
                return this.GetPropertyValue<string>("loggerName");
            }
        }

        /// <summary>
        /// Gets the host where Redis is running.
        /// </summary>
        /// <value>The host.</value>
        public string Host
        {
            get
            {
                return this.GetPropertyValue<string>("host");
            }
        }

        /// <summary>
        /// Gets the port.
        /// </summary>
        /// <value>The port.</value>
        public int Port
        {
            get
            {
                return this.GetPropertyValue<int>("port");
            }
        }

        /// <summary>
        /// Gets the database.
        /// </summary>
        /// <value>The database.</value>
        public int Database
        {
            get
            {
                return this.GetPropertyValue<int>("database");
            }
        }

        /// <summary>
        /// Gets the password.
        /// </summary>
        /// <value>The password.</value>
        public string Password
        {
            get
            {
                return this.GetPropertyValue<string>("password");
            }
        }

        /// <summary>
        /// Gets the prefix.
        /// </summary>
        /// <value>The prefix.</value>
        public string Prefix
        {
            get
            {
                return this.GetPropertyValue<string>("prefix");
            }
        }

        /// <summary>
        /// Gets a value indicating whether data should be compressed.
        /// </summary>
        /// <value><c>true</c> if data should be compressed; otherwise, <c>false</c>.</value>
        public bool Compress
        {
            get
            {
                return this.GetPropertyValue<bool>("compress");
            }
        }

        /// <summary>
        /// Gets or sets the max number of zipmap entries.
        /// </summary>
        /// <value>The max number of zipmap entries.</value>
        public int MaxZipMapEntries
        {
            get
            {
                return this.GetPropertyValue<int>("maxZipMapEntries");
            }
        }
    }
}