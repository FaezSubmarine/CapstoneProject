using Microsoft.EntityFrameworkCore.Migrations;

namespace CapstoneProject.Migrations
{
    public partial class hopefullyfinal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "User",
                keyColumn: "Id",
                keyValue: "b742dd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "003b744b-c3e7-4566-9f39-ca1f30a7da91", "AQAAAAEAACcQAAAAEOFTA7SzUt6BkIbvaWt6FYIkAqzN8DGHYiAhbvCjKaH0OjJFk4C4BAls8I+rliVecg==", "51b9429f-5335-4422-828c-be2b7e63b011" });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "User",
                keyColumn: "Id",
                keyValue: "b74dd234-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "92fa9ef6-ca35-49cd-b966-8cba3572dbf8", "AQAAAAEAACcQAAAAEIbuqwga0wBkxO0VbkobMSQLJ629TPnP0yAvHkksIl7O3STw6/6wGCwHTpzz1DOjkQ==", "838e1323-4f68-48c7-9620-3095bfc66e79" });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "User",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9abec36d-55a9-48e1-a94a-2723ba4ad693", "AQAAAAEAACcQAAAAEFt9B3xoJksO8dqXN8lBytlMmbCAPo7vs7MWSW8IP98fFmD24wlIuq9LVq3rB16pqg==", "c775ccd2-1659-4b99-82aa-efc03fd68ae2" });
        }
    }
}
