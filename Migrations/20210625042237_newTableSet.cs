using Microsoft.EntityFrameworkCore.Migrations;

namespace CapstoneProject.Migrations
{
    public partial class newTableSet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "User",
                keyColumn: "Id",
                keyValue: "b742dd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4573bd15-2458-4db2-827a-b69d2f056073", "AQAAAAEAACcQAAAAEDt+zOUVOnqPSAugDOWd6cS8TFKZxQabH+ZgxvqQFcn/AF/phuu7BBoD56R8ZazY0A==", "f490e890-6d92-43f6-a63d-ffe3635840ee" });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "User",
                keyColumn: "Id",
                keyValue: "b74dd234-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1ce266ec-1d10-4429-a5dd-40c41c1cc118", "AQAAAAEAACcQAAAAEGzF5gS6n/Nz06na5xgPqxJ/DVs0JNMYb0Kg78jVt4nymuU+K1+ocw4l1/3Yg7oujA==", "d5c23687-cdf7-435b-8065-04e9a44aa6e1" });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "User",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8a96d671-3f39-49e9-a35d-12f9e94d7cdc", "AQAAAAEAACcQAAAAEPCF11LYQUsJxil/fPU0/cVOlVddItfIY6MAeQKmS+JaktTSu+sbFBGLXIxosyALjw==", "cb3e5ad5-1cd3-4615-9c83-1008defbb1f7" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "User",
                keyColumn: "Id",
                keyValue: "b742dd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f171bbaa-a12c-4b04-876d-88efbbc72e04", "AQAAAAEAACcQAAAAEFwoHHCUWggX5UR9PtKhjS1cvbDgPzFtAnN9xjHWweC6sGSVLqCUXho+HcDe5p4+3A==", "19a0fa15-603e-4c37-ac8f-f32795436ec9" });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "User",
                keyColumn: "Id",
                keyValue: "b74dd234-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0cfe5959-7084-4144-84ba-f77f3704cd1a", "AQAAAAEAACcQAAAAEEjRIdcxYlClo7e6czjDDsz9mTE20YYwKVO5vdg7869XuFEWYFnsK7Bcxgs5MBAOJw==", "34301201-d244-440e-af1e-6af6244d0c38" });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "User",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "360c9255-6fac-45a2-b2d2-369bd6f2f004", "AQAAAAEAACcQAAAAEEOmBctqzEkj9yAwviIQ7+129zsOasGyl0EqhMlgdBiR3pcWPiZMBBwCy343LVa4vg==", "4aa28951-46f2-49c9-93ac-c1ece419a0ed" });
        }
    }
}
