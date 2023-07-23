//GET method - Retrieve data
const getData = (api: string) => {
    const requestOptions = {
      method: "GET",
    };
    return fetch(getUrl(api), requestOptions).then(handleResponse);
  };
  
  // //POST method - Creates new entry
  const postData = (api: string, body: any) => {
    const requestOptions = {
      crossDomain: true,
      method: "POST",
      headers: { "Content-Type": "application/json" },
      body: JSON.stringify(body),
    };
    return fetch(getUrl(api), requestOptions).then(handleResponse);
  };
  
  const getUrl = (api:string) => {
    return `${process.env.REACT_APP_API_URL}${api}`;
  };
  
  // Response handler helper function
  const handleResponse = (response: any) => {
    return response.text().then((text: string) => {
      const data = text && JSON.parse(text);
  
      if (!response.ok) {
        const error = (data && data.message) || response.statusText;
        return Promise.reject(error);
      }
  
      return data;
    });
  };
  
  export const fetchWrapper = {
    get: getData,
    post: postData,
    // put: putData,
    // delete: deleteData,
  };
  