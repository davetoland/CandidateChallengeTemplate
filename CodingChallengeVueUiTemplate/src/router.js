import Vue from 'vue';
import Router from 'vue-router';
import UserAccountList from './components/UserAccountList';
import CreateEditUser from './components/CreateEditUser';

Vue.use(Router);

export default new Router({
  mode: "history",
  routes: [     
    {
      path: '/',
      name: "UserAccounts",
      component: UserAccountList
    },
    {
      path: "/new",
      name: "CreateUser",
      component: CreateEditUser
    },
    {
      path: "/edit/:userId",
      name: "EditUser",
      component: CreateEditUser
    }
  ]
});
