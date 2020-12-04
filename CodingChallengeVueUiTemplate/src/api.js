import axios from "axios";

export default axios.create({
    baseURL: "https://localhost:44373",
    withCredentials: false,
    headers: {
      Accept: 'application/json',
      'Content-Type': 'application/json',
    },
});
