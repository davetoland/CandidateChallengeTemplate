<template>
  <div>
    <h1>Coding Challenge UI</h1>
    <h3>User Accounts</h3>
    <table class="table table-striped mt-5">
      <thead class="thead-dark">
        <tr>
          <th>Id</th>
          <th>First Name</th>
          <th>Last Name</th>
          <th>Email Address</th>
          <th></th>
        </tr>
      </thead>
      <tbody>
        <tr v-for="user in users" :key="user.id">
          <td>{{ user.id }}</td>
          <td>{{ user.firstName }}</td>
          <td>{{ user.lastName }}</td>
          <td>{{ user.email }}</td>
          <td>
            <button class="btn btn-secondary" @click="editUser(user.id)">Edit</button>
          </td>
        </tr>
      </tbody>
    </table>
    <div>
      <button class="btn btn-primary" @click="createUser">Create New User</button>
    </div>
  </div>
</template>

<script>
import service from "@/services/users";
export default {
  name: "UserAccounts",
  props: {
    users: [],
  },
  created() {
    this.loadUsers();
  },
  methods: {
    async loadUsers() {
      const response = await service.getUserAccounts();
      this.users = response;
    },
    async editUser(id) {
      this.$router.push({
        name: "EditUser",
        params: { userId: id },
      });
    },
    async createUser() {
      this.$router.push({ name: "CreateUser" });
    },
  },
};
</script>

<style scoped>
h3 {
  margin: 40px 0 0;
}
ul {
  list-style-type: none;
  padding: 0;
}
li {
  display: inline-block;
  margin: 0 10px;
}
a {
  color: #42b983;
}
</style>
