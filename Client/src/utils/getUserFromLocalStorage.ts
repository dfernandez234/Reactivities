export const getUserFromLocalStorage = () => {
    const localUser = localStorage.getItem("user");
    const user = localUser ? JSON.parse(localUser) : null;
    return user;
}

export const addUserToLocalStorage = (user:string) => {
    localStorage.setItem('user', JSON.stringify(user));
};
  
export const removeUserFromLocalStorage = () => {
    localStorage.removeItem('user');
};