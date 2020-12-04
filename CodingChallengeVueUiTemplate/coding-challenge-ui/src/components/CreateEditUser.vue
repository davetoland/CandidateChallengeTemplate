<template>
  <div>
    <h1>Coding Challenge UI</h1>
    <h3>{{operation}} User Account</h3>
    <div class="container">
      <div class="new-user">
        <div class="form-row">
          <div class="form-group">
            <label for="firstname">First Name:</label>
            <input type="text" name="firstname" class="form-control" v-model="user.firstName">
          </div>
        </div>
        <div class="form-row">
          <div class="form-group">
            <label for="lastname">Last Name:</label>
            <input type="text" name="lastname" class="form-control" v-model="user.lastName">
          </div>
        </div>
        <div class="form-row">
          <div class="form-group">
            <label for="email">Email Address:</label>
            <input type="text" name="email" class="form-control" v-model="user.email">
          </div>
        </div>
        <div class="form-row">
          <div class="form-group">
            <label for="password">Password:</label>
            <input type="password" name="password" class="form-control" v-model="user.password">
          </div>
        </div>
        <div class="d-flex justify-content-between">
          <button class="btn btn-secondary" @click="back">Back to User List</button>
          <button class="btn btn-primary" @click="save">Submit</button>
        </div>
      </div>
    </div>
  </div>
</template>

<script>
import service from "@/services/users";
export default {
  name: "NewUserAccount",
  data() {
    return {
      operation: "Create",
      user: {
        firstName: "",
        lastName: "",
        email: "",
        password: "",
      },
    };
  },
  mounted() {
    if (this.$route.name === "EditUser") {
      const userId = this.$route.params.userId;
      service
        .getUserAccountById(userId)
        .then((response) => {
          this.user = response;
        })
        .catch((err) => {
          console.log(err);
        });
      this.operation = "Edit";
    }
  },
  methods: {
    async save() {
      await service.createUserAccount(this.user);
      this.back();
    },
    async back() {
      this.$router.push({ name: "UserAccounts" });
    },
  },
};
</script>

<style scoped>
.new-user {
  padding: 50px 100px 50px 70px;
  width: 60%;
  margin: 0 auto;
}
.form-row {
  display: -webkit-flex;
  margin: 0 -15px;
}
.form-group {
  width: 100%;
}
label {
  width: 100%;
  text-align: left;
}
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
