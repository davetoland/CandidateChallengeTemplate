import api from '@/api';

export default {
  async getUserAccounts() {
    const url = '/users';
    try {
      const response = await api.get(url)
      return response.data;
    } catch(err) {
      console.log(err);
    }
  },

  async getUserAccountById(id) {
    const url = `/users/${id}`;
    try {
      const response = await api.get(url);
      return response.data;
    } catch(err) {
      console.log(err);
    }
  },

  async createUserAccount(account) {
    const url = '/users';
    try {
      const response = await api.post(url, account);
      return response.data;
    } catch(err) {
      console.log(err);
    }
  },

  async updateUserAccount(account) {
    const url = '/users';
    try {
      const response = await api.put(url, account);
      return response.data;
    } catch(err) {
      console.log(err);
    }
  }
}