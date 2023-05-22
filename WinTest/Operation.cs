﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Newtonsoft.Json;
using WinTest.Models;

namespace WinTest
{
    internal class Operation
    {
        static HttpClient _client = new HttpClient();
        static string UrlWebApi = "http://localhost:5000";
        public static async Task<bool> DeleteCourse(int id) 
        {
            bool result = false;
            try
            {
                var response = await _client.DeleteAsync(string.Format(UrlWebApi + "/api/courses/{0}", id));
                CheckStatusCode(response.StatusCode);
                result = true;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result;
        }
        private static void CheckStatusCode(HttpStatusCode statusCode)
        {
            if (statusCode != HttpStatusCode.OK)
            {
                throw new Exception($"Метод не выполнен: {statusCode}");
            }
        }
        public static async Task<List<Course>> GetCourses() 
        {
            try
            {
                //получение данных с помощью сервиса
                var response = await _client.GetAsync(UrlWebApi + "/api/courses");
                CheckStatusCode(response.StatusCode);
                var obj = await response.Content.ReadAsStringAsync();
                var courses = JsonConvert.DeserializeObject<List<Course>>(obj) ?? new List<Course>();
                return courses;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<Course>();
            }
        }
        public static async Task<Course> GetCourses(int id)
        {
            try
            {
                //получение данных с помощью сервиса
                var response = await _client.GetAsync(string.Format(UrlWebApi + "/api/couses/{0}", id));
                CheckStatusCode(response.StatusCode);
                var obj = await response.Content.ReadAsStringAsync();
                var course = JsonConvert.DeserializeObject<Course>(obj) ?? new Course();
                return course;
            }
            catch
            {
                return new Course();
            }
        }
        public static async Task<bool> UpdateCourse(int id, Course course)
        {
            bool result = false;
            try
            {
                HttpContent content = new StringContent(JsonConvert.SerializeObject(course), Encoding.UTF8, "application/json");
                var response = await _client.PutAsync(string.Format(UrlWebApi + "/api/courses/{0}", id), content);
                CheckStatusCode(response.StatusCode);
                result = true;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result;
        }
        public static async Task<int> InsertCourse(Course course) 
        {
            int result = 0;
            try
            {
                HttpContent content = new StringContent(JsonConvert.SerializeObject(course), Encoding.UTF8, "application/json");
                var response = await _client.PostAsync(string.Format(UrlWebApi + "/api/courses"), content);
                var resultat = await response.Content.ReadAsStringAsync();
                CheckStatusCode(response.StatusCode);
                result = Convert.ToInt32(resultat);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result;
        }
    }
}
