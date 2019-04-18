# RedisUnitTest
## C#之Redis单元测试

| CacherHelper.cs | 缓存帮助类     |
| --------------- | -------------- |
| ICache          | 接口           |
| Redis           | 实现ICache接口 |
| RedisHelper     | Redis帮助类    |
| RedisTest       | 单元测试       |

## Redis与数据库数据同步
### 数据库数据同步到Redis（推荐）
读：读取缓存Redis，如果没有数据，则读mysql，然后将从mysql中读取到的数据写入Redis。
写：数据回写mysql，写入成功后，更新或失效缓存Redis中的原值。
优点：由常规的关系型数据库，如mysql来保证数据持久化、一致性等，数据不容易出错。
### Redis数据同步到数据库（不推荐）